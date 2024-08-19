using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MVCFrameWorkProject.Models;
using NHibernate;
using NHibernate.Linq;
using ISession = NHibernate.ISession;

namespace MVCFrameWorkProject.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly ISession _session;
        private readonly ISessionFactory _sessionFactory;

        public EmployeeController()
        {
            _sessionFactory = NHibernateConfig.GetSession();
            _session = _sessionFactory.OpenSession();
        }
        public ActionResult CreateEmployeeAsync()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreateEmployeeAsync(EmployeeViewModel employeeViewModel)
        {
            try
            {
                var employee = new Employee();
                employee.EmployeeName = employeeViewModel.EmployeeName;
                employee.EmployeeAge = employeeViewModel.EmployeeAge;   

                using(var transaction = _session.BeginTransaction())
                {
                    try
                    {
                        await _session.SaveAsync(employee);
                        await transaction.CommitAsync();
                    }
                    catch(Exception ex)
                    {
                        if(transaction != null && transaction.IsActive)
                        {
                            transaction.Rollback();
                        }
                    } 
                }
                return RedirectToAction("LoadEmployeeAsync");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "ServerError";
            }

            return View(new Employee());
        }

        [HttpGet]
        public async Task<ActionResult> LoadEmployeeAsync()
        {
            var employeeToBeView = new List<EmployeeViewModel>();
            try
            {
                var employees = await _session.Query<Employee>().ToListAsync();
                employeeToBeView = employees.Select(x => new EmployeeViewModel
                { 
                    EmployeeId = x.EmployeeId,
                    EmployeeName = x.EmployeeName, 
                    EmployeeAge = x.EmployeeAge
                }).ToList();
                
            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = "Server Error!";
            }

            return View(employeeToBeView);
        }

        [HttpGet]
        public async Task<ActionResult> UpdateEmployeeAsync (int id)
        {
            var employeeToBeUpdate = new EmployeeViewModel();
            try
            {
                var employee = await _session.GetAsync<Employee>(id);
                employeeToBeUpdate = new EmployeeViewModel
                {
                    EmployeeId = id,
                    EmployeeName = employee.EmployeeName,
                    EmployeeAge = employee.EmployeeAge
                };
            }catch (Exception ex)
            {
                TempData["errorMessage"] = "Server Error!";
            }
            return View(employeeToBeUpdate);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateEmployeeAsync(EmployeeViewModel employeeViewModel)
        {
            try
            {
                using(var transaction = _session.BeginTransaction())
                {
                    var employeeDb = await _session.GetAsync<Employee>(employeeViewModel.EmployeeId);

                    employeeDb.EmployeeName = employeeViewModel.EmployeeName;
                    employeeDb.EmployeeAge = employeeViewModel.EmployeeAge;

                    await _session.UpdateAsync(employeeDb);
                    await transaction.CommitAsync();
                }
                return RedirectToAction("LoadEmployeeAsync");
            }catch (Exception ex)
            {
                TempData["errorMessage"] = "Server Error";
            }
            return View(new EmployeeViewModel());
        }
        public async Task<ActionResult> DeleteEmployeeAsync(int id)
        {
            string errorMessage = string.Empty;
            bool isValid = false;
            try
            {
                using (var transaction = _session.BeginTransaction())
                {
                    var employeeToBeDelete = await _session.GetAsync<Employee>(id);
                    await _session.DeleteAsync(employeeToBeDelete);
                    isValid = true;
                    await transaction.CommitAsync();
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                //string message = TempData["errorMessage"].ToString();
                TempData["errorMessage"] = "Server Error!";
            }
            return Json(new {isValid, errorMessage}, JsonRequestBehavior.AllowGet);

        }

        public async Task<JsonResult> GetStudentDetails(int id)
        {
            bool isValid = false;
            var employeeDetails = new EmployeeViewModel();  
            string errorMessage = string.Empty;

            try
            {
                var employeeDb = await _session.GetAsync<Employee>(id);
                if (employeeDb == null)
                {
                    errorMessage = "Employee Not Found";
                }
                else
                {
                    employeeDetails.EmployeeId = employeeDb.EmployeeId;
                    employeeDetails.EmployeeName = employeeDb.EmployeeName;
                    employeeDetails.EmployeeAge = employeeDb.EmployeeAge;
                    isValid = true;
                }

            }catch (Exception ex)
            {
                errorMessage = "Internal Server Error!";
            }

            return Json(new {IsValid = isValid, Result = employeeDetails, Message = errorMessage}, JsonRequestBehavior.AllowGet);
        }
    }
}