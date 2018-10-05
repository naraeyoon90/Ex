using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue(1);
            q.Enqueue(100);
            q.Enqueue(200);
            q.Dequeue();
            q.Enqueue(22.5);
            int aa = (int)q.Dequeue();
            q.Enqueue("가나다");

            Console.WriteLine(aa);
            while (q.Count > 0)
                Console.WriteLine(q.Dequeue());

            // Stack : 후입선출 LIFO
            // Push : 데이터 입력
            // Pop : 데이터 출력
        }
    }
}
