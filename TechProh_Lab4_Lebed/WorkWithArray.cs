using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace TechProg_Lab4_Lebed
{
    public partial class WorkWithArray : Form
    {
        public int[,] matrix;
        private int[,] matrixRes;
        private int size;
        private int d;
        ClassFor2DArrays classFor2DArrays = new ClassFor2DArrays();
        public WorkWithArray(int[,] matrix, int size)
        {
            InitializeComponent();
            this.matrix = matrix;
            this.size = size;
            classFor2DArrays.AddInfoToDataGrid(ref dataGridView1, matrix, size);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell selectedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            d = Convert.ToInt32(selectedCell.Value);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            classFor2DArrays.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            resultText.Text = "";
            if (indexesButton.Checked)
            {
                string indexes = string.Join(", ", classFor2DArrays.FindAllElementIndexes(ref dataGridView1, d));
                resultText.Text = $"Indexes of the d element: {indexes}";
            }
            if (sortButton.Checked)
            {
                matrixRes = classFor2DArrays.sortArray(matrix);
                classFor2DArrays.AddInfoToDataGrid(ref dataGridView2, matrixRes, matrixRes.GetLength(0));
            }
            if (multiplyButton.Checked)
            {
                matrixRes = classFor2DArrays.multiplayOp(matrix, d);
                classFor2DArrays.AddInfoToDataGrid(ref dataGridView2, matrixRes, matrixRes.GetLength(0));
            }
        }

        private void writeF1_Click(object sender, EventArgs e)
        {
            string selectedFolder = classFor2DArrays.SelectFolder();

            if (selectedFolder != null)
            {
                string filePath = System.IO.Path.Combine(selectedFolder, "writeF1.xml");
                classFor2DArrays.WriteToXmlFile(filePath, classFor2DArrays);
                classFor2DArrays.Serialize2DArrayToFile(filePath, matrix, "\nStarted matrix", true);
                classFor2DArrays.Serialize2DArrayToFile(filePath, classFor2DArrays.sortedMatrix, "Sorted matrix", true);
                classFor2DArrays.Serialize2DArrayToFile(filePath, classFor2DArrays.multipliedMatrix, "multiplied matrix", true);
                classFor2DArrays.Serialize2DArrayToFile(filePath, classFor2DArrays.matrixRes, "result matrix(last action with matrix(sort or multiplied))", true);
                resultText.Text = "File was successfully created";
            }
        }

        private void writeF2_Click(object sender, EventArgs e)
        {
            string selectedFolder = classFor2DArrays.SelectFolder();
            if (selectedFolder != null)
            {
                string filePath = System.IO.Path.Combine(selectedFolder, "writeF2.xml");
                classFor2DArrays.Serialize2DArrayToFile(filePath, matrix);
                resultText.Text = "File was successfully created";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void readMatrixFromFile_Click(object sender, EventArgs e)
        {
            string filePath;
            string matrixString;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML Files (*.xml)|*.xml";
                openFileDialog.Title = "Выберите XML файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
                else
                {
                    return;
                }
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                matrixString = reader.ReadToEnd();
            }

            int[,] deserializedMatrix = classFor2DArrays.Deserialize2DArrayFromString(matrixString);
            classFor2DArrays.matrix = deserializedMatrix;
            matrix = deserializedMatrix;
            classFor2DArrays.AddInfoToDataGrid(ref dataGridView1, classFor2DArrays.matrix, classFor2DArrays.matrix.GetLength(0));
        }
    }
}
