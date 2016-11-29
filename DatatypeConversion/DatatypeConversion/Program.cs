/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 6/16/2015
 * Time: 7:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DatatypeConversion
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			float f=123.4f;
			int i=(int)f;
			int i1=Convert.ToInt32(f);
			string number="100";
			int i2=int.Parse(number);
			Console.WriteLine("the value is {0}",i);
			Console.WriteLine("the value is {0}",i1);
			Console.WriteLine("the value is {0}",i2);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}