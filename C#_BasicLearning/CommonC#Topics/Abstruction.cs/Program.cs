

using Abstruction.cs;

Student student = new Student();
student.Id = 110;
student.Name = "Sohel";
student.Address = "Mirpur";
student.CFee = 2;
Console.WriteLine(student.UniInfo());
Console.WriteLine(student.CourseFee());

UniversityStuff universityStuff = new UniversityStuff();
universityStuff.Id = 11;
universityStuff.Name = "XYZ";
universityStuff.Salary = 34;
universityStuff.HourlyPay = 2;

universityStuff.BasicInfoOfEmpployee(1, "asd", "ahsf");
universityStuff.EmplyeeSalary();
universityStuff.CourseFee();