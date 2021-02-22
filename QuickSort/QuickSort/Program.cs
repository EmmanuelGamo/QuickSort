using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[10];
            int i;
            Console.WriteLine("Input 10 numbers:");
            for (i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nThe numbers in the array are: ");
            PrintElements(Numbers);
            QuickSort(Numbers,0,Numbers.Length-1);
            Console.Write("\nSorted Using Quick Sort: ");
            PrintElements(Numbers);
            Console.ReadKey();
        }
        static public void QuickSort(int[] Numbers, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(Numbers, left, right);
                if (pivot > 1)
                {
                    QuickSort(Numbers, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(Numbers, pivot + 1, right);
                }
            }
        }
        static public int Partition(int[] Numbers, int left, int right)
        {
            int pivot;
            pivot = Numbers[left];
            while (true)
            {
                while (Numbers[left] < pivot)
                {
                    left++;
                }
                while (Numbers[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = Numbers[right];
                    Numbers[right] = Numbers[left];
                    Numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        public static void PrintElements(int[] Numbers)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", Numbers[i]);
            }
        }
    }
}

