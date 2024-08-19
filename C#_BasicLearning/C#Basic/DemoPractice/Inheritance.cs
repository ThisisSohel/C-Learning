using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

FullTimeEmployee FTE = new FullTimeEmployee();
FTE.FirstName = "Rakib";
FTE.LastName = "Hasan";
FTE.Email = "xyz@gmail.com";


public class Employee
{
    public string FirstName;
    public string LastName;
    public string Email;

    public void PrintFullName()
    {

    }
}

public class FullTimeEmployee : Employee
{
    public float YearlySalary;
}
public class PartTimeEmployee : Employee
{
    public float HourlyRate;

}


