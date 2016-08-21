using System;
using System.Collections;
using System.Collections.Generic;

namespace ProtoTower
{
	public class Application
	{
		bool someValue = true;
		static String myMessage = "Hello World.";

		IDictionary configItems = new Dictionary<string,string>();

		public static void Main(string[] args)
		{
			new Application().init(args).HelloWorld();
		}

		public Application()
		{
		}

		Application init(string[] args) 
		{
			foreach (string arg in args) {
				parseArg(arg);
			}
			return this;
		}

		void HelloWorld() 
		{
			Console.WriteLine(myMessage);
		}

		void parseArg(string arg)
		{
			if (arg.StartsWith("--") || arg.StartsWith("-")) {
				string[] split = arg.Split('=');
				string key = split[0].Substring(1);
				if (key.StartsWith("-")) {
					key = key.Substring(1);				
				}
				string val = split[1];
				configItems.Add(key, val);
			}
		}
	}
}
