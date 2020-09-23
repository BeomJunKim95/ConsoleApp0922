using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
	class Array_Practice
	{
		static void ChangeArray(int[] p)
		{
			p[0]++;
		}
		static int MyMax(int[] p)
		{
			int temp = p[0];
			for(int i = 1; i < p.Length; i++)
			{
				if (temp < p[i])
					temp = p[i];
			}
			return temp;
		}
		static void Main()
		{
			int[] arr1 = new int[3] { 1, 2, 3 };

			Console.WriteLine(arr1[0]); // ? : 1
			ChangeArray(arr1);
			Console.WriteLine(arr1[0]); // ? : 2 => arr1[0]의 값이 ++된다 (배열은 ref타입이기 때문)

			int[] arr2 = new int[3] { 1, 2, 3 };

			// 원본변수를 바꾸기 싫을때 clone을 쓰면서 DeepCopy
			Console.WriteLine(arr2[0]); // ? : 1
			int[] newArr = (int[])arr2.Clone(); //clone은 오브젝트 타입 오브젝트를 배열로 암시적형변환을 할수 없으니 명시적으로 형변환을 해준다
			ChangeArray(newArr);
			Console.WriteLine(arr2[0]); // ? : 1

			Console.WriteLine(arr2.Min());
			Console.WriteLine(arr2.Max());
			Console.WriteLine(MyMax(arr2)); // 3

			int[] target = new int[5];
			arr2.CopyTo(target, 2); // 2는 배열의 2번째부터 복사를 하겠다는것 그럼 2번째 인덱스의 다음부터 복사
			PrintArray(target);
			Array.Copy(arr2, 0, target, 2, 3); //이렇게 클래스명으로 복사하는 방법도 있음
			PrintArray(target);

			int[] arr3 = new int[10] { 6, 7, 1, 2, 5, 9, 4, 8, 3, 0 };
			PrintArray(arr3); // 6,7,1,2,5,9,4,8,3,0
			Array.Sort(arr3); // 정렬은 정적메서드기 때문에 클래스명으로 호출해야한다
							  //sort는 void타입이기 때문에 원본자체를 바꿔버림
			PrintArray(arr3); // 0,1,2,3,4,5,6,7,8,9
			Array.Reverse(arr3);
			PrintArray(arr3); // 리버스는 내림차순 정렬이 아니라 인덱스반 반대로 바꿔주는것
							  // sort를 하지않고 reverse를 하면 출력내용은 0,3,8,4,9,5,2,1,7,6
							  // 내림차순을 하고싶으면 sort를하고 resverse를 하면 내림차순 정렬이 된다

			//sort를 하면 원본배열도 정렬한채로 바뀌어버린다
			//원본배열을 그대로 놔두고 정렬한 결과만 보고싶으면 clone을 쓰면 된다!
			int[] arr4 = new int[10] { 6, 7, 1, 2, 5, 9, 4, 8, 3, 0 };
			Array.Sort((int[])arr4.Clone()); 
			PrintArray(arr4);


			string str = "avdfersdfsdf";
			Console.WriteLine(str);
			Console.WriteLine(str.ToUpper());
			Console.WriteLine(str);
			//Console.WriteLine(str.Replace("sdf","000000000000000"));
			Console.WriteLine(str); //원본은 변하지 않는다

			str = str.Replace("sdf", "000000000000000"); //replace의 반환타입은 string
			Console.WriteLine(str); // 원문에 담아줬기때문에 원본도 변함

			int[,] s_arr = new int[2, 3] // 2차원배열
			{
				{ 1,2,3}, // row(행) 하나
				{ 4,5,6}  // 
			};
			//Console.WriteLine(s_arr[1,2]);
			PrintArray(s_arr);
			
		}

		private static void PrintArray(int[] target)
		{
			for (int i = 0; i < target.Length; i++)
			{
				Console.Write(target.GetValue(i) + " "); //0,0,1,2,3
			}
			Console.WriteLine();
		}
		private static void PrintArray(int[,] target)
		{
			for (int i = 0; i < target.GetLength(0); i++)  //그냥 length는 전체갯수가 넘어오기때문에 getlength 메서드를 사용해 인덱스 지정
			{
				for (int k = 0; k < target.GetLength(1); k++)
				{
					Console.Write(target[i, k] + " ");
				}
			}
			Console.WriteLine();

			foreach (int temp in target)
			{
				Console.Write(temp + " ");
			}
			Console.WriteLine();
		}
	}
}
