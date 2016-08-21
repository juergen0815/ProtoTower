using System;

namespace ProtoTower
{
	public class Application
	{
		bool someValue = true;

		public static void Main(string[] args)
		{
			new Application().helloWorld();
		}

		public Application()
		{
		}

		void helloWorld() {
			Console.WriteLine("Hello World!");
		}
	}
}
