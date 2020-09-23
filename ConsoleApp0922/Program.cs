using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
	class Program
	{
		static int Sqr(int x)
		{
			return  x * x;
		}
		static int Sqr(ref int x)
		{
			//x = x * x;
			return x * x; // 이상태에서 아래 메인함수에서 변수에 담아주지않으면 여기서 바뀌어도 3이나온다
		}
		static void GetName(out string name, out int id) // 아웃의 특징은 반드시 메서드 안에 값을 새로 할당해주는 코드가 있어야한다
		{
			Console.Write("Enter Name : ");
			name = Console.ReadLine();
			Console.Write("Enter Id : ");
			id = int.Parse(Console.ReadLine()); 
		}
		static void PrintIntParams(params int[] arr) //params : 가변인자 명령어
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + " ");
			}
			Console.WriteLine();
		}
		static void Main(string[] args)
		{
			int a = 3;
			a = Sqr(a);
			Console.WriteLine("Value: {0}", a); // ? : 3

			int b = 3;
			Sqr(ref b);
			Console.WriteLine("ref: {0}", b); // ? : 9

			string name;
			int id;
			GetName(out name, out id);
			Console.WriteLine("out: {0}  {1}", name, id); // ?

			PrintIntParams(1, 2, 3, 4);

			int[] myIntArray = { 5, 6, 7, 8, 9 };
			PrintIntParams(myIntArray);

			PrintIntParams();
		}
	}
}
