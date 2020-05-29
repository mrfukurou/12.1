using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp26
{
    class mas
    {
        int[,] IntArray;
        int n,m;

        public mas() { }

        public mas(int N, int M)
        {
            n = N;
            m = M;
            IntArray = new int[n, m];
        }

        public int[,] Input()
        {
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    IntArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return IntArray;

        }

        public void Output()
        {
            for (int i = 0; i < IntArray.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < IntArray.GetLength(1); ++j)
                    Console.Write("{0,5} ", IntArray[i, j]);
        }
        public int this[int i, int j]
        {
            get
            {
                if (i < 0 || i > IntArray.GetLength(0) - 1 && j < 0 || j > IntArray.GetLength(1) - 1)
                {
                    throw new Exception("Элемента с таким индексом нет.");
                }
                return IntArray[i, j];
            }
            set
            {
                if (i < 0 || i > IntArray.GetLength(0) - 1 && j < 0 || j > IntArray.GetLength(1) - 1)
                {
                    throw new Exception("Элемента с таким индексом нет.");
                }
                IntArray[i, j] = value;
            }
        }
       
        public static mas operator ++(mas increment)
        {
            for (int i = 0; i < increment.IntArray.GetLength(0); i++)
            {
                for (int j = 0; j < increment.IntArray.GetLength(1); j++)
                    increment.IntArray[i, j] += 1;
            }
            return increment;
        }
        public static mas operator --(mas decrement)
        {
            for (int i = 0; i < decrement.IntArray.GetLength(0); i++)
            {
                for (int j = 0; j < decrement.IntArray.GetLength(1); j++)
                    decrement.IntArray[i, j] -= 1;
            }
            return decrement;
        }

        public static bool operator true(mas q)
        {
            int n = q.IntArray.GetLength(0);
            int m = q.IntArray.GetLength(1);
            if (n == m) return true;
            else return false;
        }
        public static bool operator false(mas q)
        {
            int n = q.IntArray.GetLength(0);
            int m = q.IntArray.GetLength(1);
            if (n != m) return false;
            else return true;
        }

        public static mas operator +(mas a, mas b)
        {
                int[,] intArray = new int[a.IntArray.GetLength(0), b.IntArray.GetLength(1)];
                mas result = new mas();
                for (int i = 0; i < a.IntArray.GetLength(0); i++)
                {
                    for (int j = 0; j < a.IntArray.GetLength(1); j++)
                    {
                        intArray[i, j] = a[i, j] + b[i, j];
                    }
                }
                result.IntArray = intArray;
            return result;
        }
        public static explicit operator int[,](mas p)
        {
            return p.IntArray;
        }

        public static explicit operator mas(int[,] IntArray)
        {
            mas p = new mas(IntArray.GetLength(0), IntArray.GetLength(1));
            IntArray.CopyTo(p.IntArray, 0);
            return p;
        }
    }
}


