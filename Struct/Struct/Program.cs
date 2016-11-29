/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 7/11/2015
 * Time: 10:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

public struct Customer{
	private int id;
	private string name;
	public int Id{
		set{
			this.id=Id;
		}
		get{
			return this.id;
		}
	}
	public string Name{
		get{
			return this.name;
		}
		set{
			this.name=Name;
		}
	}
	public Customer(int Id,string Name){
	this.id=Id;
	this.name=Name;
	}
	public void printDetail(){
		Console.WriteLine("name is {0} and id is {1}",this.id,this.name);
	}
	
}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			Customer c=new Customer(12,"babak");
			c.printDetail();
			Customer c1=new Customer();
			c1.Id=14;
			c1.Name="amir";
			c1.printDetail();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
