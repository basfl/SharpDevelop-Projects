/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 11/1/2016
 * Time: 10:02 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;


	interface Inf{
		
		 void f();
		
	}
	class A : Inf{
		 public void f(){
			Console.WriteLine("f");
		}
	}
	abstract public class Wash{
		  abstract public  void show();
	}
	public class B:Wash,Inf{
		 public override void show(){
			Console.WriteLine("B: show");
		}
		public void f(){
			Console.WriteLine("B: f");
		}
		
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			B b=new B();
			b.f();
			b.show();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
