using System;
using System.Collections.Generic;
using System.Linq;
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


    }
}
