using System;
using System.Collections;
using System.Collections.Generic;

namespace ProtoTower
{
	public class Application
	{
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
				parseArg(arg);
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

		void parseArg(string arg)
		{
			if (arg.StartsWith("--") || arg.StartsWith("-"))
			{
				string[] split = arg.Split('=');
				string key = split[0].Substring(1);
				if (key.StartsWith("-"))
				{
					key = key.Substring(1);
				}
				OnParam cb = (OnParam)configItems[key];
				if (cb != null) {
					string val = split.Length > 1 ? split[1] : null;
					cb(val);
				} else {
					Console.WriteLine("Invalid option " + arg);
				}
			}
		}
	}
}
