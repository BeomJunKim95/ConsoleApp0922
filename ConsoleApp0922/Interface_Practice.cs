using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
	interface IMan  //클래스와 같은 위치니까 네임스페이스 안에 선언
		{
			string Name { get; set; }
			void Save();
			void Show();
		}
	interface IPerson : IMan
	{
		int Age { get; set; }
	}
	class Employee : IPerson  //리팩토링으로 모든멤버를 명시적으로 구현 보다는 인터페이스 구현이 더 자주쓰는 방법
							  //위에 상속받은 인터페이스에 메서드를 하나라도 정의하지 않으면 오류
	{
		int age;
		public int Age { get { return age; } set { age = value; } }

		string name;
		public string Name { get { return name; } set { name = value; } }

		public void Save()
		{
			Console.WriteLine("Name : " + this.name);
		}

		public void Show()
		{
			Console.WriteLine("Name : " + this.name);
			Console.WriteLine("Age : " + this.age);
		}
	}
	class Interface_Practice
	{
		static void Main()
		{
			//IMan man = new IMan(); //인터페이스는 new불가능 : 정의가 다 끝나지 않았으니까
			Employee man = new Employee(); // IMan 이라 man.을하면 Age가 나오지않음 IPerson,Employee라고 하면 나옴
			Console.Write("이름 : ");
			man.Name = Console.ReadLine();
			Console.Write("나이 : ");
			man.Age = int.Parse(Console.ReadLine());
			man.Save();
			man.Show();
		}
	}
}
