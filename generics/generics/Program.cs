using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{

    /*
        Generics : int, float, double과 같은 데이터 타입을 확정하지 않고 이 데이터타입 자체를 타입 파라미터로 받아들이도록
                    하는 기능

        * 선언방식

        접근제한차 반환형식 메소드이름<형식매개변수>(매개변수)
        {
        
        }
        
        void CopyData(int a, int b)
        {
            b = a;
        }

        위의 방식은 데이터 형식에 따라서 여러개의 매소드가 필요함 비효율

        위의 방식을 Generics로 변환하면

        void CopyData<T> (T a, T b)
        {
            b = a;
        }

    */
    // 일반화 클래스 선언방식
    // 일반화 클래스는 똑같은 기능을 하지만 내부적으로 사용하는 데이터 형식이 다를 경우에 사용하면 편리

    /*
        class 클래스명<T>
        {
            
        }

        class DemoList
        {
            private int[] array;
            public int GetItem(int idx)
            {
                return array[idx];
            }
        }

        class DemoList<T>
        {
            private T[] array;
            public T GetItem(int idx) 
            {
                return array[idx];
            }
        }

        DemoList<int> demoList = new DemoList<int>();
    */

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
            //int[] data = { 1, 2, 3, 5 };
            //int[] data2 = new int[data.Length];

            //CopyData<int>(data, data2);

            //foreach (int item in data2)
            //    Console.WriteLine(item);

            // 제네릭 클래스

            MyList<string> myList1 = new MyList<string>();
            myList1[0] = "A";
            myList1[1] = "B";
            myList1[2] = "C";
            myList1[3] = "D";
            myList1[4] = "E";

            for (int i = 0; i < myList1.Length; i++)
            {
                Console.WriteLine(myList1[i]);
            }
        }
    }

    class MyList<T>
    {
        private T[] array;

        public MyList()
        {
            array = new T[4];
        }

        public T this[int idx]
        {
            get
            {
                return array[idx];
            }
            set
            {
                if (idx >= array.Length)
                {
                    Array.Resize<T>(ref array, idx + 1);
                    Console.WriteLine($"배열 사이즈조정 : {array.Length}");
                }
                array[idx] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }
    }
}
