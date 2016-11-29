/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 11/2/2016
 * Time: 3:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ExplicitInterface
{
	interface L1{
		void f();
	}
	interface L2{
		void f();
	}
	public class P :L1,L2{
		 void L1.f(){
			Console.WriteLine("l1");
		}
	 void L2.f(){
			Console.WriteLine("l2");
		}
	}
	abstract class Customer{
		public abstract void func();
	}
	class User:Customer{
		public override void func(){
			Console.WriteLine("USER");
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			P a=new P();
			((L1)a).f();
			((L2)a).f();
		
			User user=new User();
			user.func();
			
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}