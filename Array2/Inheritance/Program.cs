/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 10/28/2016
 * Time: 2:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Inheritance
{
	public class Employee{
		private string firstName;
		private string lastName;
		private string email;
		public string FirstName{
			get{
				return firstName;
			}
			set{
				firstName=value;
			}
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			Employee e=new Employee();
			e.FirstName="bob";
			Console.Write("Press any key to continue . . . "+e.FirstName);
			Console.ReadKey(true);
		}
	}
}