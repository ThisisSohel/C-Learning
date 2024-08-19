namespace SimpleAsync1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting file downloads...");

            List<string> files = new List<string> { "file1.txt", "file2.txt", "file3.txt" };
            await DownloadFilesAsync(files);

            Console.WriteLine("All files downloaded.");
        }

        public async Task DownloadFilesAsync(List<string> files)
        {
            List<Task> downloadTasks = new List<Task>();

            foreach (string file in files)
            {
                downloadTasks.Add(DownloadFileAsync(file));
            }

            await Task.WhenAll(downloadTasks);
        }

        public static async Task DownloadFileAsync(string fileName)
        {
            Console.WriteLine($"Starting download for {fileName}");

            await Task.Delay(1000);
            Console.WriteLine($"{fileName}");
        }
    }
}
