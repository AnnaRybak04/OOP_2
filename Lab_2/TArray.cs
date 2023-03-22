namespace Lab_2
{
    internal class TArray 
    {
        public TArray(){ }
        public void Task1(double []arr)
        {
            double mult = 1;
            for(int i=0; i<arr.Length; i++)
            {
                mult *= arr[i];
            }
           Console.WriteLine("Cереднє геометричне: "+ Math.Pow(mult, (1.0/arr.Length)));
        }
        public void Task2(double[]vector, double a)
        {
            double[] v = new double[vector.Length];
            for(int i=0; i<vector.Length; i++)
            {
                v[i] = vector[i] * a;
                Console.Write(v[i] + " ");
            }
        }
        public void Task3(double[] arr)
        {
            BubbleSort(arr);
            Array.Reverse(arr);
            for(int i=0;i< arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
        public void BubbleSort(double[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        double temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
       
    }
}
