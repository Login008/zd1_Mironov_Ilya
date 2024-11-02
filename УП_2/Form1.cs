namespace УП_2
{
    public partial class Form1 :Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShopForm f1 = new ShopForm();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayListForm f1 = new PlayListForm();
            f1.Show();
        }
    }
}
