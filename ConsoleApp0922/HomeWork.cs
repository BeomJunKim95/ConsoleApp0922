using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
	
	class HomeWork
	{
		static void PrimeNum(int num)
		{
			bool flag = true;
			for ( int i = 2; i < num; i++)
			{
				
				for (int j = 2; j < i; j++)
				{
					if (i % j == 0)
						flag = false;
				}
				if(flag == true)
					Console.Write(i + " ");
				flag = true;
			}
			
		}
			
		static void Main()
		{
			int num = 0;
			Console.Write("숫자를 입력하세요 : ");
			num = int.Parse(Console.ReadLine());
			PrimeNum(num);
		}
	}
}
