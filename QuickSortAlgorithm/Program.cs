using System;

namespace QuickSortAlgorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 3, 2, 8, 4, 9 };
            QuickSort(a, 0, a.Length - 1);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{a[i]}");
            }
        }
        public static void Swap(int[] a, int i, int j)
        {
            int t = a[i];
            a[i] = a[j];
            a[j] = t;
        }
        private static int Partition(int[] a, int l, int r)
        {
            int ndx = l;
            int pivot = a[l];
            for (int i = l + 1; i <= r; i++)
            {
                if (a[i] < pivot)
                {
                    ndx++;
                    Swap(a,ndx, i);
                }
            }
            Swap(a, ndx, l);
            return ndx;
        }

        private static void QuickSort(int[] a, int l, int r)
        {
            if (l < r)
            {
                var pi = Partition(a, l, r);
                QuickSort(a, l, pi - 1);
                QuickSort(a, l, pi +1);
            }
        }
    }
}




