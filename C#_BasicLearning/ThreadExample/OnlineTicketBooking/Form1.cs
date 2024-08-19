using System.Diagnostics;

namespace OnlineTicketBooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FoodOrder();
        }

        private void FoodOrder()
        {
            new Thread(() =>
            {
                MessageBox.Show($"Please Wait your food order ....");
                Thread.Sleep(10000);
                MessageBox.Show("Food order is done! ");
            }).Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                Process.Start(new ProcessStartInfo { FileName = @"https://youtu.be/YErrKU1dq0g", UseShellExecute = true });
            }).Start();
        }
    }
}
