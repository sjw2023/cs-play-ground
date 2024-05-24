using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace cs_play_ground
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Array array = Array.CreateInstance(typeof(int), 10);
			Object obj = new object();

 			obj = array;

			MethodInfo[] methodInfos = obj.GetType().GetMethods();
			foreach (MethodInfo methodInfo in methodInfos)
			{
				Console.WriteLine(methodInfo.Name);	
			}

			Console.WriteLine($"{obj.GetType().InvokeMember("GetValue", System.Reflection.BindingFlags.InvokeMethod, null, obj, new object[] { 0 })}");
			obj.GetType().InvokeMember("SetValue", System.Reflection.BindingFlags.InvokeMethod, null, obj, new object[] { 1, 0 });

		}
	}
}
