using System;

namespace ProtoTower
{
	public class Application
	{
		static String myMessage = "Hello World";

		public static void Main(string[] args)
		{
			new Application().HelloWorld();
		}

		public Application()
		{
		}

		void HelloWorld() {
			Console.WriteLine(myMessage);
		}
	}
}
