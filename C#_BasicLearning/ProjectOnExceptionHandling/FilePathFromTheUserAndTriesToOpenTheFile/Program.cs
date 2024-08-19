namespace FilePathFromTheUserAndTriesToOpenTheFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = @"C:\Users\User\Desktop\Log.txt";
                using (StreamReader sr = new StreamReader(filePath))
                {
                    Console.WriteLine(sr.ReadToEnd());
                    Console.WriteLine("File opened successfully!");
                }

            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
