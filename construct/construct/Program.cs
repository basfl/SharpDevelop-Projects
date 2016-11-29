/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 10/3/2016
 * Time: 11:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace construct
{
	struct Point{
		private int x;
		public int X{
			get{ return (this.x);}
			set{x=x;}
			
		}
		
		
	}
	class ObjA{
		public int a;
		
		public ObjA() : this(2){
			Point p=new Point();
			p.X=12;
			Console.Write("\n p is"+p.X);
				
			
		}
		public ObjA(int a){
			this.a=a;
		}
		public void display(){
			Console.Write("varible a is "+a);
			
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			ObjA objA=new ObjA();
			objA.display();
			Console.WriteLine("\n Hello World!");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
		}
	}
}