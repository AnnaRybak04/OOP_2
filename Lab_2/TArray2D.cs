namespace Lab_2
{
    internal class TArray2D
    {
        public TArray2D() { }

        public void Task1(int[,] arr)
        {
            int[,] newArr = new int[arr.GetLength(0), arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        newArr[i, j] = arr[i, j];
                    }
                }
                else
                {
                    int[] row = new int[arr.GetLength(1)];

                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        row[j] = arr[i, j];
                    }
                    Array.Sort(row);
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        newArr[i, j] = row[j];
                    }
                }
            }
            printArray(newArr);
        }

        public void Task2(int[,] arr)
        {
            bool flag = false;
            int count = 0;

            for(int j=0; j < arr.GetLength(1); j++)
            {
                flag = false;
                for(int i=0; i < arr.GetLength(0); i++)
                {
                    if(arr[i, j] == 0)
                    {
                        flag = true;
                        break;
                    }   
                }
                if(!flag) count++;
            }

           Console.WriteLine("Кількість стовпців: "+ count);
        }
        public void Task3(int[,] arr)
        {
            Dictionary<int[], int> arrays = new Dictionary<int[], int>();
          
            for (int i=0; i < arr.GetLength(0); i++)
            {
                int sum = 0; 
                int[] row = new int[arr.GetLength(1)];
                for(int j=0; j< arr.GetLength(1); j++)
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
                int[] row = item.Key;
              
                for(int i = 0;i < arr.GetLength(1); i++)
                {
                    Console.Write(row[i] + " ");
                }
                Console.WriteLine("  Sum:  "+ item.Value);
                
            }
        }
        public static void printArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
