/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 6/17/2015
 * Time: 8:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace array
{
	class Program
	{
		public static void Main(string[] args)
		{
			int [] arr=new int[3]{1,2,3};
			foreach(int i in arr){
				Console.WriteLine("the element is {0}",i);
			}
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}