/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 7/1/2015
 * Time: 10:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

 
class Employee{
	public string firstName;
	public string lastName;
	public void printFullName(){
		Console.WriteLine(" firstName is "+ firstName +" lastName is "+lastName +" base");
	}
}
class PartTime: Employee{
	public new void printFullName(){
		Console.WriteLine(" firstName is "+ firstName +" lastName is "+lastName +" part Time");
		base.printFullName();
	}
}
class FullTime: Employee{
	
}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			FullTime ft=new FullTime();
			PartTime pt=new PartTime();
			ft.firstName="babak";
			ft.lastName="slf";
			ft.printFullName();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
