/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 10/28/2016
 * Time: 2:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace inheritance
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
		public string LastName{
			get{
				return lastName;
			}
			set{
				lastName=value;
			}
		}
		public string Email{
			get{
				return email;
			}
			set{
				email=value;
				
			}
		}
		public void show(){
			
		}
		
	}
	public class FullTime : Employee
	{
		float salary;
		public void reocrd(){
			base.show();
			Console.WriteLine("fitst ="+FirstName+"last= "+LastName);
		}
	}
	public class Base{
		public virtual void print(){
			Console.WriteLine("here is base");
		}
	}
	public class Drive :Base{
		public  override void print(){
			Console.WriteLine("here is Drive");
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			//Employee e=new Employee();
		//	e.FirstName="babak";
		//	e.LastName="slf";
		//	FullTime full=new FullTime();
		//	full.FirstName="amir";
		//	full.LastName="slf";
		//	
		//	full.reocrd();
		//	Console.WriteLine("Hello World! "+e.FirstName);
			
			// TODO: Implement Functionality Here
			
			Base b=new Drive();
			b.print();
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}