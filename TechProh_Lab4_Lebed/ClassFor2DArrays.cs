using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace TechProg_Lab4_Lebed
{
    public class ClassFor2DArrays
    {
        [XmlIgnore]
        public int[,] matrix { get; set; }
        [XmlIgnore]
        public int[,] matrixRes { get; set; }
        
        public int size { get; set; }

        public string Indexes { get; set; }
        [XmlIgnore]
        public int[,] sortedMatrix { get; set; }
        [XmlIgnore]
        public int[,] multipliedMatrix { get; set; }

        public ClassFor2DArrays(int size)
        {
            this.size = size;
            matrix = new int[size, size];
        }

        public ClassFor2DArrays(int[,] matrix)
        {
            this.matrix = matrix;
        }

        public ClassFor2DArrays() { 
        }

        public int[,] generate2dArray(int min, int max, int size)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            if (min > max) { (min, max) = (max, min); }
            if (min == max) { min = 0; max = 100; }
            for (int i = 0; i < size;i++)
            {
                for (int j = 0; j < size;j++)
                {
                    matrix[i, j] = rnd.Next(min, max);
                }
            }
            this.matrix = matrix;
            return matrix;
        }

        public string FindAllElementIndexes(ref DataGridView dgv, object element)
        {
            StringBuilder indexesString = new StringBuilder();

            for (int i = 0; i < dgv.RowCount; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value != null && dgv.Rows[i].Cells[j].Value.Equals(element))
                    {
                        string indicesString = $"{element}[{i}][{j}]";
                        indexesString.Append(indicesString).Append(", ");
                    }
                }
            }

            if (indexesString.Length > 0)
            {
                indexesString.Length--;
            }
            Indexes = indexesString.ToString();
            return indexesString.ToString();
        }

        public int[,] sortArray(int[,] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);
            int[,] sortMatrix = new int[rowCount, columnCount];

            for(int j = 0; j<columnCount; j++)
            {
                int[] column = new int[rowCount];
                for(int i = 0; i<rowCount; i++)
                {
                    column[i] = matrix[i, j];
                }
                Array.Sort(column, (x, y) => y.CompareTo(x));

                for(int i =0; i< rowCount;i++)
                    sortMatrix[i,j] = column[i];
            }
            sortedMatrix = sortMatrix;
            matrixRes = sortMatrix;
            return matrixRes;
        }

        public int[,] multiplayOp(int[,] matrix, int valueF)
        {
            int rowCount = matrix.GetLength(0);
            int h = rowCount;
            int columnCount = matrix.GetLength(1);
            int[,] array = new int[rowCount, columnCount];
            Array.Copy(matrix, array, matrix.Length);

            for(int i = 0; i < rowCount; i++)
            {
                for(int j = 0; j < columnCount; j++)
                {
                    if (array[i,j] % 3 == 0) { array[i, j] *= -h; }
                    else { array[i, j] -= valueF; }
                }
            }
            multipliedMatrix = array;
            matrixRes = array;
            return matrixRes;
        }

        public void AddInfoToDataGrid(ref DataGridView dgv, int[,] matrix, int size)
        {
            dgv.Rows.Clear();
            dgv.ReadOnly = true;
            dgv.ColumnCount = size;
            dgv.RowCount = size;
            for(byte i = 0; i < dgv.ColumnCount; ++i)
            {
                dgv.Columns[i].Width = 30;
                dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;

            for(byte i = 0; i < size; ++i)
            {
                for(byte j=0;j<size;++j)
                    dgv[j, i].Value = matrix[i ,j];
            }
        }

        public void Clear()
        {
            matrix = null;

        }


        public string SelectFolder()
        {
            using(FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if(folderDialog.ShowDialog() == DialogResult.OK)
                    return folderDialog.SelectedPath;
            }
            return null;
        }

        public void WriteToXmlFile(string filePath, object objectToWrite)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ClassFor2DArrays));
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
            {
                xmlWriterSettings.Indent = true;
                xmlWriterSettings.IndentChars = "\n";
            }

            using (XmlWriter xmlWriter = XmlWriter.Create(filePath, xmlWriterSettings))
            { 
                serializer.Serialize(xmlWriter, objectToWrite);
            }
        }

        public void Serialize2DArrayToFile<T>(string filePath, T[,] array, string label, bool append = false)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            using (StreamWriter writer = new StreamWriter(filePath, append))
            {
                writer.WriteLine(label);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        writer.Write(array[i, j]);

                        if (j < columns - 1)
                        {
                            writer.Write(",");
                        }
                    }
                    writer.WriteLine();
                }
                writer.WriteLine();
            }
        }

        public void Serialize2DArrayToFile<T>(string filePath, T[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        writer.Write(array[i, j]);

                        if (j < columns - 1)
                        {
                            writer.Write(",");
                        }
                    }
                    writer.WriteLine();
                }
                writer.WriteLine();
            }
        }

        public int[,] Deserialize2DArrayFromString(string matrixString)
        {
            string[] rows = matrixString.Trim().Split('\n');
            int rowCount = rows.Length;
            int columnCount = rows[0].Split(',').Length;

            int[,] matrix = new int[rowCount, columnCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] values = rows[i].Split(',');

                for (int j = 0; j < columnCount; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            return matrix;
        }
    }
}
