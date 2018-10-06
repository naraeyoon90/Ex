using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yieldEx
{
    class Program
    {
        // Enumerator (Iterator) : 집합적인 데이터셋으로부터 데이터를 하나씩 호출자에게 보내주는 기능
        // yield 키워드는 호출자에게 컬렉션데이터를 하나씩 리턴할 때 사용하는 키워드

        /*
            yield 사용방식
            - yield reurn : 컬렉션 데이터를 하나씩 리턴하는데 사용
            - yield break : 리턴을 중지하고 Iteration 루프를 빠져나올 때 사용 
        */

        static IEnumerable<int> GetNumber()
        {
            yield return 1;
            yield return 2;
            yield return 3;

        }

        static void Main(string[] args)
        {
            foreach (int num in GetNumber())
            {
                Console.WriteLine(num);
            }
        }
    }
}
