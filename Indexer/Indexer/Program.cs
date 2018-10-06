using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    // 인덱서 : 인덱서 클랙스 객체의 데이터를 배열 형태로 인덱스를 사용해서 액세스할 수 있도록 해주는 것 
    //          객체를 마치 배열처럼 사용할 수 있도록 해줌

    /*
        인덱스 선언방법
        class 클래스명
        {
            접근제한자 인덱서형식 this[형식 index]

            {
                get
                {
                    idx를 이용해서 내부데이터를 반환
                }

                set
                {
                    idx를 이용해서 내부 데이터를 저장
                }
            }                
        }
    */
    class DemoList
    {
        private int[] array;

        public DemoList()
        {
            array = new int[4];
        }

        public int this[int idx]
        {
            get
            {
                return array[idx];
            }
            set
            {
                if (idx >= array.Length)
                {
                    Array.Resize<int>(ref array, idx + 1);
                    Console.WriteLine($"배열 사이즈 조정: {array.Length}");
                }
                array[idx] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }
    }
    class Program
    {    
        static void Main(string[] args)
        {
            DemoList list = new DemoList();

            for (int i = 0; i < 5; i++)
            {
                list[i] = i;
            }

            for (int i = 0; i < list.Length; i++)
            {
                list[i] = i;
            }
        }
    }
}
