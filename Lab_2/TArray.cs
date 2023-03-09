using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class TArray 
    {
        private int[] array;
        private int[,] array2;
        public TArray() { }
        public TArray(int[] arr)
        {
            array = arr;
        }

       
        public double Task1(double []arr)
        {
            double mult = 1;
            for(int i=0; i<arr.Length; i++)
            {
                mult *= arr[i];
            }

            return Math.Pow(mult, 1/arr.Length);
        }
        public double[] Task2(double[]vector, double a)
        {
            double[] v = {};
            for(int i=0; i<vector.Length; i++)
            {
                v[i] = vector[i] * a;
            }
            return v;
        }
        public double[] Task3(double[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            return arr;
        }
       
    }
}
