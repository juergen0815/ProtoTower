using System;
using System.Collections;
using System.Collections.Generic;

namespace ProtoTower
{
	public class Application
	{
		bool someValue = true;
		delegate void OnParam(string param);

		static String myMessage = "Hello World.";

		IDictionary configItems = new Dictionary<string,OnParam>();

		public static void Main(string[] args)
		{
			new Application().init(args).HelloWorld();
		}

		public Application()
		{
		}

		Application init(string[] args) 
		{
			configItems.Add("help", (OnParam)configHelp);
			configItems.Add("path", (OnParam)configPath);
			foreach (string arg in args) {
				//parseArg(arg);
			}
			return this;
		}

		void HelloWorld() 
		{
			Console.WriteLine(myMessage);
		}

		void configHelp(string param) {
			Console.WriteLine("HELP: Fancy Hello World by me.");
		}

		void configPath(string path) {
			Console.WriteLine("PATH ");
		}

	}
}
