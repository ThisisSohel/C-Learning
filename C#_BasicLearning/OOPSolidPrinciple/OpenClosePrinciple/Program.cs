namespace OpenClosePrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewLogger newLogger = new NewLogger("Hello");
            newLogger.Info("Hi");

            Student student = new Student()
            {
                FName = "Joe",
                LName = "Mike"
            };

            Course onlineCourse = new OnlineCourse()
            {
                Title = "Software Engineer"
            };

            onlineCourse.Subscribe(student);
        }
    }
}
