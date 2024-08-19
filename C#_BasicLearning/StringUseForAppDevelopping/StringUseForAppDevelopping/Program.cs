namespace StringUseForAppDevelopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person();
            per.Id = 1;
            per.Name = "Sohel";
            per.PersonCreate(per);

            //person.PersonList(1);

            Person per1 = new Person();
            per1.Id = 2;
            per1.Name = "Sohel1";
            per1.PersonCreate(per1);

            Person per2 = new Person();
            per2.Id = 2;
            per2.Name = "Sohel21";
            per2.PersonCreate(per2);

            String[] myArr = { "The", "quick", "brown", "fox" };

            string[] myArr2 = { "Hello", "Hi", "Hey" };

            try
            {
                Array.Copy(myArr2, myArr, 2);

            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Array.Sort(myArr);
            for (int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine(myArr[i]);
            }
            Console.WriteLine(Array.BinarySearch(myArr, 3, 1,"quick"));
            Array.Clear(myArr);
            Console.WriteLine("The string array initially contains the following values:");
            for(int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine(myArr[i]);
            }

            IList<string> myList = Array.AsReadOnly(myArr);

            try
            {
                myList.Remove("fox");
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
