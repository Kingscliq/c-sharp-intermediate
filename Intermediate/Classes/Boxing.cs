using System;
using System.Collections;
namespace Intermediate.Classes
{
	public class Boxing
	{
		public static void CreateList()
		{
			var list = new ArrayList();

			list.Add(1);
			list.Add("Mosh");
			list.Add(true);


			Console.WriteLine("The first element in the list is {0}", list[1]);
		}
	}
}

