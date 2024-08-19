using Encaptulation.cs;

public class Program
{
    public static void Main()
    {
        Student student = new Student();
        student.FName = "Sohel";
        student.LName = "Rana";

        Console.WriteLine(student.FullNameGet());
        UniversityInfo info = new UniversityInfo();
        info.UniversityName = "EWU";
        info.UniversityId = 1;
        info.UniAddress = "Aftab";
        info.FullUniversityInfo();

    }
}
