using System;
using System.Threading;
using System.Threading.Tasks;

namespace 대리자
{
    class Program
    {
        //빌드 후 VS2019 개발자 명령 프롬포트에서 ildasm 실행하여 어셈블리 확인
        //대리자 형식을 정의하였을 때 어셈블리에서 형식 확인 가능
        delegate int DemoDele(int a, int b);
        static void Main(string[] args)
        {
            //개체 생성
            DemoDele dele1 = new DemoDele(Add);
            DemoDele dele2 = new DemoDele(Sub);
            DemoDele dele3 = Add;
            DemoDele lamDele = delegate (int a, int b) { return a * b; };   //무명 대리자 스타일

            //메소드 호출
            Console.WriteLine("{0}", dele1(2, 3));
            Console.WriteLine("{0}", dele1(3, 4));
            Console.WriteLine("{0}", dele1(5, 3));
            Console.WriteLine("{0}", dele3.Invoke(3, 8));
            Console.WriteLine("{0}", lamDele.Invoke(3, 8));

            //대리자의 더하기와 빼기 연산
            dele3 = dele1 + dele2;
            Console.WriteLine(dele3(4, 7));
            dele3 -= dele2;
            Console.WriteLine(dele3(4, 7));

        }

        static int Add(int a, int b)
        {
            Console.WriteLine("Add");
            return a + b;
        }
        static int Sub(int a, int b)
        {
            Console.WriteLine("Sub");
            return a - b;
        }

    }
}
