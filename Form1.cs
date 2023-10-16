namespace RandomTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            label1.Text = rd.Next(1, 41).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}