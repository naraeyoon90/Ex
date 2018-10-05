using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionEx
{
    class Program
    {
        static void Main(string[] args)
        {

            // Que : 선입선출 FIFO 
            Queue q = new Queue();

            q.Enqueue(1);
            q.Enqueue(100);
            q.Enqueue(200);
            q.Dequeue();
            q.Enqueue(22.5);
            int aa = (int)q.Dequeue();
            q.Enqueue("가나다");

            Console.WriteLine("--Queue--");
            Console.WriteLine(aa);
            while (q.Count > 0)
                Console.WriteLine(q.Dequeue());

            // Stack : 후입선출 LIFO
            // Push : 데이터 입력
            // Pop : 데이터 출력

            Console.WriteLine("--Stack--");
            Stack stack = new Stack();
            stack.Push(100);
            stack.Push(11);
            stack.Pop();
            stack.Push(2.33);
            stack.Pop();
            stack.Push("문자열");

            while (stack.Count > 0)
                Console.WriteLine(stack.Pop());

            // HashTableEx
            // Hashing 알고리즘을 이용한 데이터 검색이 이루어지는 방식의 자료구조
            // 키를 이용해서 한번에 데이터가 저장되어 있는 컬렉션 내의 주소를 계산해 낸다.

            Console.WriteLine("--Hashtable--");
            Hashtable ht = new Hashtable();
            ht["Apple"] = "사과";
            ht["Orange"] = "오렌지";
            ht["Banana"] = "바나나";

            Console.WriteLine(ht["Apple"]);
            Console.WriteLine(ht["Orange"]);
            Console.WriteLine(ht["Banana"]);
        }
    }
}
