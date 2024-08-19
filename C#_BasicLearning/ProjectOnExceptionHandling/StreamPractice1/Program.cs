namespace StreamPractice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\User\Desktop\streamPractice.txt";
            try
            {
                string[] str = { "hello", "hi", "hey" };

                using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.None))
                {
                    Console.WriteLine("File is Created!");


                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        for (int i = 0; i < str.Length; i++)
                        {
                            sw.WriteLine(str[i]);
                        }
                        sw.WriteLine("Hello!");
                        
                    }

                    using (StreamReader sr = File.OpenText(filePath))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            string path = @"C:\Users\User\Desktop\SourceFile.txt";
            string path2 = @"C:\Users\User\Desktop\NewFile.txt";
            FileInfo fi1 = new FileInfo(path);
            FileInfo fi2 = new FileInfo(path2);

            try
            {
                // Create the source file.
                using (FileStream fs = fi1.Create()) { }

                //Ensure that the target file does not exist.
                if (File.Exists(path2))
                {
                    fi2.Delete();
                }

                //Copy the file.f
                fi1.CopyTo(path2);
                Console.WriteLine("{0} was copied to {1}.", path, path2);
            }
            catch (IOException ioex)
            {
                Console.WriteLine(ioex.Message);
            }


        }
    }
}
