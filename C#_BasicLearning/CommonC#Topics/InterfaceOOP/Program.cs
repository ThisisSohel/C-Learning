namespace InterfaceOOP
{
    interface IFile
    {
        public void ReadFile();

        public virtual void  DisplayName()
        {
            Console.WriteLine("IFile...........");
        }
        public sealed void DisplayName1()
        {
            Console.WriteLine("IFile Sealed...........");
        }
        public virtual void DisplayName2()
        {
            Console.WriteLine("IFile virtual...........");
        }
    }
    interface IBinaryFile
    {
        public void ReadBinaryFile();
        void ReadFile();
    }

    class FileInfo : IFile, IBinaryFile
    {
        public void ReadBinaryFile()
        {
            Console.WriteLine("Opening Binary File");
        }

        public void ReadFile()
        {
            Console.WriteLine("Reading Text File");
        }

        void IBinaryFile.ReadFile()
        {
            Console.WriteLine("Reading Binary File");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IFile file1 = new FileInfo();
            IBinaryFile file2 = new FileInfo();
            FileInfo file3 = new FileInfo();

            file1.ReadFile();
            file1.DisplayName1();
            file1.DisplayName2();
            file2.ReadFile();
            file2.ReadBinaryFile();
        }
    }
}
