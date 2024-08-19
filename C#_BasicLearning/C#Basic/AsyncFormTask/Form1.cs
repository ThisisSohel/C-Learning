using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AsyncFormTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() =>
            {
                for (long i = 0; i <= long.MaxValue; i++)
                {
                }
            });
            t.Start();

            //Task.Run(() =>
            //{
            //    for (long i = 0; i <= long.MaxValue; i++)
            //    {
            //    }
            //});
        }
        private void label1_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
