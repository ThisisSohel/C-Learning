namespace OneDArrayWebSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool iteration = true;
            while (iteration)
            {
                Console.WriteLine("1- Add user");
                Console.WriteLine("2- List user");
                Console.WriteLine("3- Single user Search");
                Console.WriteLine("4- Multiple user Search");
                Console.WriteLine("5- Student Update");


                var input = Console.ReadLine();
                if (int.TryParse(input, out int reuslt))
                {
                    switch (reuslt)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter user Id: ");

                                var id = Console.ReadLine();
                                if(!int.TryParse(id, out int stuId))
                                {
                                    Console.WriteLine("Enter a neumaric student Id");
                                }
                                else
                                {
                                    Console.WriteLine("Enter user Name: ");
                                    string name = Console.ReadLine();
                                    UserDataBinding(stuId, name);
                                }


                                void UserDataBinding(int id, string name)
                                {
                                    Student st = new Student();
                                    st.Id = id;
                                    st.Name = name;
                                    st.AddStudent(st);
                                }
                                break;
                            }
                        case 2:
                            {
                                Student sList = new Student();
                                sList.StudentList();
                                break;
                            }
                        case 3:
                            {
                                Student sSearch = new Student();
                                Console.WriteLine("Enter student Name whom you want to search:");
                                var id = Console.ReadLine();
                                if (!int.TryParse(id, out int stuId))
                                {
                                    Console.WriteLine("Enter a neumaric student Id");
                                }
                                else
                                {
                                    sSearch.StudentFind(stuId);
                                }

                                break;
                            }
                        case 4:
                            {
                                Student sList = new Student();
                                Console.WriteLine("Enter student name to search: ");
                                string name = Console.ReadLine();
                                sList.AllStudentSearch(name);

                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("Enter the Id of student to Update name");
                                Student updaterStudent = new Student();
                                var id = Console.ReadLine();
                                if (!int.TryParse(id, out int stuId))
                                {
                                    Console.WriteLine("Enter a neumaric student Id");
                                }
                                else
                                {
                                    Console.WriteLine("Enter student name");
                                    string updaterName = Console.ReadLine();
                                    updaterStudent.StudentUpdate(stuId, updaterName);
                                }
                                break;
                            }
                        case 6:
                            {

                                break;
                            }
                        case 7:
                            {

                                break;
                            }
                        case 8:
                            {

                                break;
                            }
                        case 10:
                            {

                                iteration = false;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Enter a valid input");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("Please input a numeric number: ");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }

            }
        }
    }
}
