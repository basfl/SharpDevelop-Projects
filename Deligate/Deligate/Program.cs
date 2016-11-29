/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 11/3/2016
 * Time: 4:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Deligate
{
	
	public delegate void MessgFunctionDelegate(string str);
	public delegate int AddFunctionDelegate(int a,int b);
	 delegate bool IsPromted(Employee e);
	class Employee{
		public int ID{get;set;}
		public string Name{get;set;}
		public int Experiance {get;set;}
		public int salary {get;set;}
		public void promteEmployee(List<Employee> Employees,IsPromted ip){
			foreach(Employee em in Employees){
				if(ip(em)){
					Console.Write("promted "+em.Name+"\n");
				}
			}
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			// delegate is type safe function=pointer that points to function
			MessgFunctionDelegate mfd=new MessgFunctionDelegate(messg);
			mfd("hello from del");
			AddFunctionDelegate afd=new AddFunctionDelegate(add);
		
			Console.WriteLine("Hello World!"+afd(3,4));
			
			List<Employee> le=new List<Employee>();
			le.Add(new Employee(){Name="babak",ID=5,Experiance=6,salary=100});
			le.Add(new Employee(){Name="amir",ID=6,Experiance=7,salary=100});
			le.Add(new Employee(){Name="parisa",ID=5,Experiance=4,salary=100});
			Employee e=new Employee();
			IsPromted ip=new IsPromted(canPromot);
		
			e.promteEmployee(le,ip);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static bool canPromot(Employee e){
			if(e.Experiance>5){
					return true;
			}else{
				return false;
			}
		}
		public static void messg(string str){
			Console.WriteLine("message "+str);
		}
		public static int add(int a,int b){
			return(a+b);
		}
	}
}