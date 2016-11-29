/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 11/6/2014
 * Time: 4:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace test
{
	class A{
		public int add(int a,int b){
			return (a+b);
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World! babak");
			
			// TODO: Implement Functionality Here
			int a=2;
			String s="babak";
			A obj=new A();
			Console.WriteLine("Add is "+obj.add(3,4));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}