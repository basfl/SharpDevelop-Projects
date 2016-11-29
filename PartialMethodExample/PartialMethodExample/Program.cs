/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 11/20/2016
 * Time: 3:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PartialMethodExample
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			PartialOne po=new PartialOne();
			po.f();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}