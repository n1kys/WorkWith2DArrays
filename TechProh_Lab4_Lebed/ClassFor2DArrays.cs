using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TechProh_Lab4_Lebed
{
    public class ClassFor2DArrays
    {
        public int[,] matrix { get; set; }

        public double[,] matrixRes { get; set; }
        
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

        public int[,] generate2dArray(int min, int max)
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




    }
}
