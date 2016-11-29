/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 10/8/2016
 * Time: 2:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Inher
{
	class Felidae{
		private bool male;
		public Felidae():this(true){
			
		}
		public Felidae(bool male){
			this.male=male;
		}
		public bool Male{
			get{return male;}
			set{this.male=value;}
		}
		public void f(){
			Console.WriteLine("\n we are calling the base");
		}
	}
	class Lion:Felidae{
		private int weight;
// Keyword "base" will be explained in the next paragraph
public Lion(bool male, int weight) : base(male)
	{
	this.weight = weight;
	base.f();
	
	}
	public int Weight
	{
		get { return weight; }
		set { this.weight = value; }
	}
	
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Felidae Felidae=new Felidae();
			
			
			Lion lion=new Lion(true,150);
			Console.Write("\n my lions weight is "+lion.Weight +"male is "+lion.Male );
			lion.f();
			Console.ReadKey(true);
			
		}
	}
}