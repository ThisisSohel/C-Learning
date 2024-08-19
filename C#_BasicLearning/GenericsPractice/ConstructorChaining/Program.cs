namespace ConstructorChaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.ManagerInfo();

            Employee employee = new Employee();
            employee.ManagerInfo();
        }
    }
}
