/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 9/25/2016
 * Time: 11:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using myDLL;

namespace Array2
{
	class A :Interface1
	{
		
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			MyClass myClass=new MyClass();
			myClass.f();
			
			
			// TODO: Implement Functionality Here
			
			int [] arr={1,2,3,4,5,6};
			foreach(int a in arr){
				Console.WriteLine(a);
			}
			int [] arr2=new int[3];
			for(int i=0;i<arr2.Length;i++){
				arr2[i]=i;
			}
			foreach(int i1 in arr2){
				Console.WriteLine("****"+i1);
			}
			int num=123;
			List<int> rev=new List<int>();
			while(num>0){
				int m=num%10;
				rev.Add(m);
				num=num/10;
			}
			
			foreach(int i in rev){
				Console.WriteLine(i);
			}
			Dictionary<string,string> dict=new Dictionary<string, string>();
			dict.Add("name","babak");
			foreach(var item in dict){
				Console.WriteLine("key is "+item.Key);
				
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}