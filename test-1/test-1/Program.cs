/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 9/19/2016
 * Time: 9:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace test_1
{
	interface IMyInterface
{
    void MethodToImplement();
}
	class Program : IMyInterface
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			double f=1.2;
			bool cond=true;
			float f1= 0.0f;
			int a=1;
			int b=2;
			bool ABGreater=(a>b);
			char c='a';
			int? n=null;
			if(ABGreater){
				Console.WriteLine(">");
			}else{
				Console.WriteLine("<"+n.HasValue);
			}
			
			
			Console.Write("Press any key to continue . . . "+f1);
			Console.ReadKey(true);
		}
		public void MethodToImplement(){
			Console.Write("Press any key to continue ***** ");
		}
	}
}