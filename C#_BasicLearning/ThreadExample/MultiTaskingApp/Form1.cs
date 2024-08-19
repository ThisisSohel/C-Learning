namespace MultiTaskingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OperationTaskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                OperationTaskList.Items.Add(i);
            }
        }

        private void Work1_Click(object sender, EventArgs e)
        {
            DoTimeWork();
            Work2_Click(sender, e);
        }
        
        private void DoTimeWork()
        {
            new Thread (() =>
            {
                Thread.Sleep(5000);
                MessageBox.Show("Work Done!");
            }).Start ();
        }

        private void Work2_Click(object sender, EventArgs e)
        {
            DoTimeWork();
            OperationTaskList_SelectedIndexChanged(sender, e);
        }
    }
}
