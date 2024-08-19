using System.Net;
using System.Windows.Forms.Design;

namespace FIleDownloads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SongDownload();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            FileDownload();
        }

        void SongDownload()
        {

            new Thread(() =>
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://filesamples.com/samples/video/mpeg/sample_1280x720_surfing_with_audio.mpeg", "song.mpeg");
                }
                MessageBox.Show("Song1 Download Finish!");

            }).Start();


            new Thread(() =>
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://filesamples.com/samples/video/mpeg/sample_960x400_ocean_with_audio.mpeg", "song1.mpeg");
                }
                MessageBox.Show("Song2 Download Finish!");
            }).Start();


            new Thread(() =>
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://filesamples.com/samples/video/mpeg/sample_640x360.mpeg", "song2.mpeg");
                }
                MessageBox.Show("Song3 Download Finish!");
            }).Start();

        }

        void FileDownload()
        {
            new Thread(() =>
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://filesamples.com/samples/video/mpeg/sample_1280x720_surfing_with_audio.mpeg", "File1.mpeg");
                }
                MessageBox.Show("File1 Download Finish!");


                using (var client = new WebClient())
                {
                    client.DownloadFile("https://filesamples.com/samples/video/mpeg/sample_960x400_ocean_with_audio.mpeg", "File2.mpeg");
                }
                MessageBox.Show("File2 Download Finish!");


                using (var client = new WebClient())
                {
                    client.DownloadFile("https://filesamples.com/samples/video/mpeg/sample_640x360.mpeg", "File3.mpeg");
                }
                MessageBox.Show("File3 Download Finish!");

            }).Start();

        }

    }
}
