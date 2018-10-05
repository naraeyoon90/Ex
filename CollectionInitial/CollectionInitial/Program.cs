using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
//using staticConsole;

namespace CollectionInitial
{
    class Program
    {
        static void Main(string[] args)
        {
            // 컬렉션 초기자를 이용한 초기화 방법
            // 컬렉션 초기자는 IEnumerable 인터페이스를 상속받아서 Add() 매소드를 구현하고 있음
            ArrayList arrayList = new ArrayList() { 10, 20, 30};
            foreach (object obj in arrayList)
                Console.WriteLine($"초기자 : {obj}");

            // 컬렉션 초기자는 Stack과 Queue에서는 사용할 수 없음.
            // Add 매소드가 없기 때문이다.

            int[] array = { 11, 22, 33, 44 };

            ArrayList arrayList2 = new ArrayList(array);

            foreach (object obj in arrayList2)
            {
                Console.WriteLine($"ArrayList : {obj}");
            }
            Console.WriteLine();

            Stack stack = new Stack(array);
            foreach (object obj in stack)
                Console.WriteLine($"Stack : {obj}");

            Console.WriteLine();

            Queue queue = new Queue(array);
            foreach (object obj in queue)
                Console.WriteLine($"Queue : {obj}");


            Console.WriteLine();

            // HashTable을 초기화할 때 딕셔너리 초기자 Dictionary Initializer를 이용할 수 있음
            // 방법1
            Hashtable ht = new Hashtable()
            {
                ["sel"] = "서울",
                ["inc"] = "인천",
                ["kwa"] = "광주"
            };

            Console.WriteLine(ht["sel"]);
            Console.WriteLine(ht["kwa"]);
            
            // 방법2
            Hashtable ht2 = new Hashtable()
            {
                { "sel", "서울"},
                { "kwa", "광주"}
            };
            Console.WriteLine(ht["sel"]);
            Console.WriteLine(ht["kwa"]);

        }
    }
}
