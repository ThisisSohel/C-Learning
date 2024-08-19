namespace StreamBasicOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\User\Desktop\myArray.txt";
            using (FileStream file = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            {
                int[] arr = new int[5] { 10, 20, 22, 23, 45 };
                int[] arr2 = new int[arr.Length];
                Console.WriteLine("File Created!");
                //using (StreamWriter sr = new StreamWriter(file))
                //{
  
                //    for (int i = 0; i < arr.Length; i++)
                //    {
                //        sr.WriteLine(arr[i]);
                //    }
                //    Console.WriteLine("Array Inserted into the file!");
                //}

                using (StreamReader sr = new StreamReader(file))
                {

                    string line = "";
                    int i = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        arr2[i] = int.Parse(line);
                        i++;
                    }
                    //for (int i = 0; i < arr.Length; i++)
                    //{
                    //    string inputNum = sr.ReadLine();
                    //    arr2[i] = Convert.ToInt32(inputNum);
                    //}

                }

                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.WriteLine(arr2[i]);
                }
            }
            
        }
    }
}
