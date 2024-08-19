using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

namespace URIExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var urlString = "https://stackoverflow.com/questions/23779441/how-to-define-a-url-in-c-sharp";
                WebRequest webRequest = WebRequest.Create("http://www.contoso.com/default.html");
                webRequest.Credentials = CredentialCache.DefaultCredentials;
                //HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
                Console.WriteLine("URL found");
                //Console.WriteLine(webRequest.StatusDescription);


                Process.Start(new ProcessStartInfo { FileName = @"https://stackoverflow.com/questions/23779441/how-to-define-a-url-in-c-sharp", UseShellExecute = true });
                Process.Start(new ProcessStartInfo { FileName = @"https://www.tutorialsteacher.com/csharp", UseShellExecute = true});

                var process = new ProcessStartInfo{ FileName = @"iexplore.exe", UseShellExecute = true };
                process.Arguments = "http://bing.com";
                Process.Start(process);

            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.ToString());
            }catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UriFormatException ex)
            {
                Console.WriteLine(ex.Message);
            }catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
