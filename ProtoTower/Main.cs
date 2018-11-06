using System;

namespace ProtoTower
{
	public class Application
	{
		static String myMessage = "Hello World.";

		public static void Main(string[] args)
		{
			new Application().init(args).HelloWorld();
		}

		public Application()
		{
		}

		Application init(string[] args) {
			// TODO: parse some args here.	
			return this;
		} 

		void HelloWorld() {
			Console.WriteLine(myMessage);
		}
	}
}
