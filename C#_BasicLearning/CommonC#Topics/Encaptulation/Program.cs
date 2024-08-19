

using System.Xml.Linq;
Student student = new Student();
student.FirstName = "RAkib";
student.LastName = "Afsar";
student.FullName();

University university = new University();
university.Id = 1;
university.Name = "AIU";
university.Address = "fhgfghf";
university.FullUniInfo();
class Student
{
    private string fName { get; set; }
    private string lName { get; set; }

    public string FirstName
    {
        get { return fName; }
        set { fName = value; }
    }
    public string LastName
    {
        get { return lName; }
        set { lName = value; }
    }

    public void FullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

class University
{
    private int _id { get; set; }
    private string _name { get; set; }
    private string _address { get; set; }

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }
    public void FullUniInfo()
    {
        Console.WriteLine("Name: {0} Id: {1} Address: {2}", Name, Id, Address);
    }


}