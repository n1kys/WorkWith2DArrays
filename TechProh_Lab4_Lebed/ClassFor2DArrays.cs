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
        public int[,] matrix { get; set; }

        public int[,] matrixRes { get; set; }
        
        public int size { get; set; }

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
            return matrix;
        }

        public List<string> FindAllElementIndexes(ref DataGridView dgv, object element)
        {
            List<string> indexesList = new List<string>();

            for (int i = 0; i < dgv.RowCount; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value != null && dgv.Rows[i].Cells[j].Value.Equals(element))
                    {
                        string indicesString = $"{element}[{i}][{j}]";
                        indexesList.Add(indicesString);
                    }
                }
            }

            return indexesList;
        }

        public int[,] sortArray(int[,] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int columnCount = matrix.GetLength(1);
            int[,] sortedMatrix = new int[rowCount, columnCount];

            for(int j = 0; j<columnCount; j++)
            {
                int[] column = new int[rowCount];
                for(int i = 0; i<rowCount; i++)
                {
                    column[i] = matrix[i, j];
                }
                Array.Sort(column, (x, y) => y.CompareTo(x));

                for(int i =0; i< rowCount;i++)
                    sortedMatrix[i,j] = column[i];
            }
            matrixRes = sortedMatrix;
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
            matrixRes = array;
            return matrixRes;
        }

        public string ArrayToString()
        {
            StringBuilder array = new StringBuilder();
            for (byte i = 0; i < size; i++)
            {
                for (byte j = 0; j < size; j++)
                    array.Append(matrix[i,j]); array.Append(" ");
                array.Append("-");
                array.Append(Environment.NewLine);
            }
            return array.ToString();
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


        public static string SelectFolder()
        {
            using(FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if(folderDialog.ShowDialog() == DialogResult.OK)
                    return folderDialog.SelectedPath;
            }
            return null;
        }

        public void WriteToXmlFile<T>(string filePath, T objectToWrite, bool append = false) where T: new()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
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


    }
}
