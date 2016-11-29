/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 7/11/2015
 * Time: 10:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

class Human{
	public Human(){
		Console.WriteLine("WELCOME");
	}
	public Human(string msg){
		Console.WriteLine("WELCOME "+msg);
	}
	public void func(){
		Console.WriteLine("hello");
	}
	public void H(){
		Console.WriteLine("H");
	}
}
class Person:Human{
	//string name;
	public Person():base("TODAY"){
	
	}
	public string name{
		get;
		set;
	}
	
	public new void func(){
		Console.WriteLine("hello human");
	}
	public  int sum(int a,params int []a1){
		int sum=0;
		int? temp=null;
		int y=temp ?? 12;
		Console.WriteLine("temp value is {0}",y);
		foreach(int element in a1){
			sum=element+sum;
		}
		return sum;
		
	}
}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			Person p=new Person();
			p.func();
			p.name="babak";
//			P.last="amir";
			Console.WriteLine(p.name);
			Console.WriteLine(p.sum(2,1,2,3,4));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
