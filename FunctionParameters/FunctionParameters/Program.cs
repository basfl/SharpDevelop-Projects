/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 11/25/2016
 * Time: 1:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace FunctionParameters
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			add(2,3,5,6);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void add(int a,int b,params object[] numbers){
			int result=a+b;
			if(numbers !=null){
				foreach(int i in numbers){
					result=result+i;
				}
			}
			Console.WriteLine("result is "+result);
		}
	}
}