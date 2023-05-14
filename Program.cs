using  System;

class Program{

    static void Main(string[] args){
           Console.Write("Enter the size of the array: ");
           int size = int.Parse(Console.ReadLine());

           int[] arr = new int[size];

            Console.Write("Enter the number of consecutive elements to sum: ");
            int numConsecutive = int.Parse(Console.ReadLine());
            numConsecutive = (numConsecutive*2) + 1  ;

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element #" + (i+1) + ": ");
            
                arr[i] = int.Parse(Console.ReadLine());
            }

           

            int maxSum = int.MinValue;
            int maxSumIndex = 0;

            for (int i = 0; i < arr.Length - numConsecutive + 1; i++)
            {
                int sum = 0;
                for (int j = 0; j < numConsecutive; j++)
                {
                    sum += arr[i + j];
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxSumIndex = i;
                }
            }

            Console.WriteLine(maxSum);
            //Console.WriteLine("The maximum sum of " + numConsecutive + " consecutive numbers is: " + maxSum);
            /*
            Console.Write("The numbers are: ");
            for (int i = 0; i < numConsecutive; i++)
            {
                Console.Write(arr[maxSumIndex + i] + " ");
            }
            Console.WriteLine();
            */
            }
}