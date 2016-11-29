/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 6/13/2015
 * Time: 11:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace commen_operator
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			int numerator=10;
			int denumerator=2;
			int result=numerator/denumerator;
			Console.WriteLine("\n the result is {0}",result);
			check();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		private  static void check(){
			Console.WriteLine("inside function");
			int num=10;
			bool isNumber10;
			if(num==10){
				isNumber10=true;
			}
			else{
				isNumber10=false;
			}
			Console.WriteLine("the number is {0}",isNumber10);
			Console.WriteLine("\n ************** alter");
			isNumber10=num==10? true :false;
			Console.WriteLine("the number is {0}",isNumber10);
			
		}
	}
}