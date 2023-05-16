namespace TechProg_Lab4_Lebed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutAuthor_Click(object sender, EventArgs e)
        {
            InfoAboutAuthor info = new InfoAboutAuthor();
            info.Show();
        }
    }
}