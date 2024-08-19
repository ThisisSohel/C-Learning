namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async Task button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                for (long i = 0; i < long.MaxValue; i++)
                {
                }
            });
        }
    }
}
