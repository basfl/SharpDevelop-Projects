/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 11/15/2016
 * Time: 12:05 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Reflection
{
	public class Customer{
		public int id;
		public string name;
		public int Id{
			get{ return id;}
			set{id=value;}
			
		}
		public string Name{
			get{return name;}
			set{name=value;}
		}
		public Customer(){
			Console.WriteLine("customer");
		}
		public Customer(int id,string name){
			this.Id=id;
			this.Name=name;
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Type t=Type.GetType("Reflection.Customer");
			
			t.GetProperties();
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}