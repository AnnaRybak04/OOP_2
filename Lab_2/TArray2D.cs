using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class TArray2D
    {
        int[,] arr;
        int rows, columns;

     /*   public TArray2D (int a , int b)
        {
            arr =new int [a, b];
            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    arr[i,j]=int.Parse(Console.ReadLine());
                }
            }
            rows = a;
            columns = b;
        }*/
        public TArray2D(int[,] arr)
        {
            this.arr = arr.Clone() as int[,];
            rows=arr.GetLength(0);
            columns=arr.GetLength(1);
        }
        public int[,] Task1()
        {

            int[,] newArr = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        newArr[i, j] = arr[i, j];
                    }
                }
                else
                {
                    int[] row = new int[columns];

                    for (int j = 0; j < columns; j++)
                    {
                        row[j] = arr[i, j];
                    }
                    Array.Sort(row);
                    for (int j = 0; j < columns; j++)
                    {
                        newArr[i, j] = row[j];
                    }
                }
            }
            return newArr;
        }

        public int Task2()
        {
            bool flag = false;
            int count = 0;

            for(int j=0; j < columns; j++)
            {
                flag = false;
                for(int i=0; i < rows; i++)
                {
                    if(arr[i, j] == 0)
                    {
                        flag = true;
                        break;
                    }   
                }
                if(!flag) count++;
            }

            return count;
        }
        public void Task3()
        {

            Dictionary<int[], int> arrays = new Dictionary<int[], int>();
          
            for (int i=0; i < rows; i++)
            {
                int sum = 0; 
                int[] row = new int[columns];
                for(int j=0; j<columns; j++)
                {
                    row[j] = arr[i, j];
                    
                    if (j % 2 == 0 && arr[i, j] > 0) 
                        sum += arr[i, j];
                }

                arrays.Add(row, sum);
            }

            var sortedDict = arrays.OrderBy(x => x.Value);

            foreach (var item in sortedDict)
            {
                int[] arr = item.Key;
              
                for(int i =0;i < columns; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine(item.Value);
                Console.WriteLine();
            }
        }
    }
}
