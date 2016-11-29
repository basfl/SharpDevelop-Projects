/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 11/19/2016
 * Time: 1:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PartialClasses
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			Demo demo=new Demo();
			demo.FirstName="babak";
			demo.LastName="slf";
			
			Console.Write("Press any key to continue . . . "+demo.fullName());
			Console.ReadKey(true);
		}
	}
}