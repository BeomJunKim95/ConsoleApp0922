using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
	class Abstract_Class
	{
		interface IRunnable2
		{
			void Run();
		}
		interface IFlyable2
		{
			void Fly();
		}
		interface IBigDick2
		{
			void BigDick();
		}
		abstract class Fly
		{
			public abstract void CFly();
		}

		class FlyingBike2 : Fly, IRunnable //인터페이스 대신 추상클래스도 상속 가능
										   //추상클래스는 반드시 재정의 해야함
		{
			public override void CFly()
			{
				Console.WriteLine("Bike Fly");
			}

			public void Run()
			{
				Console.WriteLine("Bike Run");
			}
		}
		class FlyingCar2 : Fly, IRunnable
		{
			public override void CFly()
			{
				Console.WriteLine("Car Fly");
			}

			public void Run()
			{
				Console.WriteLine("Car Run");
			}
		}
		class FlyingWoosick2 : IFlyable, IRunnable
		{
			public void Fly()
			{
				Console.WriteLine("우식형님 날으신다.");
			}

			public void Run()
			{
				Console.WriteLine("우식형님 달리신다.");
			}
		}
		static void Main()
		{
			FlyingCar2 car = new FlyingCar2();
			car.CFly();
			car.Run();
			Flying(car);

			FlyingBike2 bike = new FlyingBike2();
			bike.CFly();
			bike.Run();
			Flying(bike);

			Fly[] arr = new Fly[3];
			arr[0] = new FlyingCar2();
			arr[1] = new FlyingBike2();
			arr[2] = new FlyingBike2();

			foreach(Fly temp in arr)
			{
				temp.CFly();
			}
		}

		static void Flying(Fly flyer) // 다형성에 있어서 인터페이스와 추상클래스는 차이가없다
		{
			flyer.CFly();
		}
	}
}
