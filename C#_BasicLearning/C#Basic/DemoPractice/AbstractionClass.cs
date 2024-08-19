
//Student student = new Student();
//student.UniversityDetails();

public abstract class University
{

    public abstract void UniversityDetails();
}
public class Student : University
{
    public override void UniversityDetails()
    {
        Console.WriteLine("University details....");
    }
}

public abstract class Name
{
    public abstract int Id { get; set; }
}

public class Name1 : Name
{
    public override int Id
    {
        get { return Id; }
        set { Id = value; }
    }
}