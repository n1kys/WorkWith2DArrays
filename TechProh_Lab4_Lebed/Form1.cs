namespace TechProg_Lab4_Lebed
{
    public partial class Form1 : Form
    {
        private string file_name;
        private ClassFor2DArrays classFor2DArrays;
        public Form1()
        {
            InitializeComponent();
            classFor2DArrays = new ClassFor2DArrays();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutAuthor_Click(object sender, EventArgs e)
        {
            InfoAboutAuthor info = new InfoAboutAuthor();
            info.Show();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(sizeUpDown1.Value)<1) { sizeUpDown1.Value = 10; }

            else
            {
                ClassFor2DArrays classFor2DArrays = new ClassFor2DArrays((int)sizeUpDown1.Value);
                classFor2DArrays.matrix = classFor2DArrays.generate2dArray((int)minUpDown2.Value, (int)maxUpDown3.Value, (int)sizeUpDown1.Value);
                WorkWithArray workWithArray = new WorkWithArray(classFor2DArrays.matrix, classFor2DArrays.size);
                workWithArray.matrix = classFor2DArrays.matrix;
                workWithArray.ShowDialog();
            }
        }
    }
}