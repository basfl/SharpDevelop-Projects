/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 11/11/2016
 * Time: 12:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MyLIb;
namespace Exception_example
{
	class Program
	{
		public static void Main(string[] args)
		{
			A a1=new A();
			a1.f();
			Console.WriteLine("Hello World!");
			MyClass myc=new MyClass();
			myc.show();
			
			// TODO: Implement Functionality Here
			try{
				Console.WriteLine("enter the first number");
			int a=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter the second number");
			int b=Convert.ToInt32(Console.ReadLine());
			int r= a/b;
			Console.Write("result is {0}",r);
			
			}catch(Exception e){
				Console.WriteLine(""+e.Message);
			}
			
			
			
			Console.ReadKey(true);
		}
		public static void f(){
		}
	}
}