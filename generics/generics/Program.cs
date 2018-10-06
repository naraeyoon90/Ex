using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class Program
    {

        // 일반화 매소드
        static void CopyData<T> (T[] a, T[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }
        }
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 3, 5 };
            int[] data2 = new int[data.Length];

            CopyData<int>(data, data2);

            foreach (int item in data2)
                Console.WriteLine(item);
        }
    }
}
