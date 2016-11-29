/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 10/30/2016
 * Time: 10:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Structure_Example
{
	struct departement{
		private int id;
		private string name;
		public int Id{
			get{return id;}
			set{id=value;}
		}
		public string Name{
			get{return name;}
			set{name=value;}
		}
		
		
		public void f(){
			Console.WriteLine("id is {0} and name is {1}",id,name);
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			departement dep=new departement();
			dep.Id=102;
			dep.Name="math";
			dep.f();
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}