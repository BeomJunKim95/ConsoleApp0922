using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
	class Class1
	{
		//static void Sum(int end)
		//{
		//	int tot = 0; //항상 누적을 구할땐 변수선언후 초기화
		//	for (int i = 1; i <= end; i++)
		//	{
		//		tot += i;
		//	}
		//	Console.WriteLine(tot);
		//}
		//항상 이렇게 오버라이드를 해야할까? 
		static void Sum (int step, int start=1, int end=100/*, int step*/) // 그럴때 쓰는게 선택적 매개변수 => 필수인걸 주고싶다면 선택파라미터보다 앞에 있어야한다
																		   //                                ex) int step
		{
			int tot = 0; //항상 누적을 구할땐 변수선언후 초기화
			for (int i = start; i <= end; i += step)
			{
				tot += i;
			}
			Console.WriteLine(tot);
		}
		static void Main()
		{
			Sum(1,1,100);
			Sum(1, 90);
			Sum(1,end:100); // 명명된 파라미터
			Sum(1);
			//Sum(); //선택적 매개변수로 인해 인자를 입력하지않아도 기본값인 1,100 더해서 출력
		}
	}
}
