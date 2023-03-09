using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
namespace Lab_2 {

    class Program
    {
        static void Main(string[] args)
        {
           
            int [,] a2 ={ 
                        { 0,0,4,5},
                        { 9,3,9,5},
                        { 9,9,4,2},
                        { 5,5,0,0} };
            TArray2D arr = new TArray2D(a2);
            arr.Task3();
           

        }
    } 

}