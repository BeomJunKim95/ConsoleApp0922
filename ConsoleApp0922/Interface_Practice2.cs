using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922
{
	interface IRunnable
	{
		void Run();
	}
	interface IFlyable
	{
		void Fly();
	}
	interface IBigDick
	{
		void BigDick();
	}
	
	class FlyingBike : IFlyable, IRunnable, IBigDick //인터페이스는 다중 상속가능
	{
		public void BigDick()
		{
			throw new NotImplementedException();
		}

		public void Fly()
		{
			Console.WriteLine("Bike Fly");
		}

		public void Run()
		{
			Console.WriteLine("Bike Run");
		}
	}
	class FlyingCar : IFlyable, IRunnable
	{
		public void Fly()
		{
			Console.WriteLine("Car Fly");
		}

		public void Run()
		{
			Console.WriteLine("Car Run");
		}
	}
	class FlyingWoosick : IFlyable, IRunnable
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
	class Interface_Practice2
	{
		static void Main()
		{
			FlyingCar car = new FlyingCar();
			car.Fly();
			car.Run();
			Flying(car);

			FlyingBike bike = new FlyingBike();
			bike.Fly();
			bike.Run();
			Flying(bike);

			FlyingWoosick woosick = new FlyingWoosick();
			woosick.Fly();
			woosick.Run();
			Flying(woosick);
		}

		//static void Flying(FlyingCar car)
		//{
		//	car.Fly();
		//}
		//// 이렇게 메서드를 오버라이드를 해야지 바이크와 카를 같이 쓸수있을까? 형변환? -> 불가능
		//static void Flying(FlyingBike car)
		//{
		//	car.Fly();
		//}

		// 인자를 클래스타입이 아닌 부모타입의 인터페이스로 정의 해주면 가능하다 => 인터페이스의 다형성, 자식은 부모로 자동형변환 가능
		static void Flying(IFlyable flyer) 
		{
			flyer.Fly();
		}
		static void Running(IRunnable runnable)
		{
			runnable.Run();
		}
	}
}
