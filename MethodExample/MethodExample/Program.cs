/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 6/21/2015
 * Time: 3:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;



	class Program
	{
		
		public static void Main(string[] args)
		{
			int i=0;
			int j=0;
			int sum=0;
			int product=0;
			int []arr=new int[3]{1,2,3};
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			Program p=new Program();
			p.evenNumber();
			addNumber(2,3);
			passByValue(i);
			Console.WriteLine("passbyvalue is {0}",i);
			passByRef(ref i);
			
			Console.WriteLine("passbyref is {0}",i);
			
			calculate(2,3,out sum,out product);
			Console.WriteLine("sum is {0}",sum);
			Console.WriteLine("product is {0}",product);
			parammCal(arr);
			Console.WriteLine("\n ************************");
			parammCal(5,6,7);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public void evenNumber(){
			int evenNumber=2;
			while(evenNumber<20){
				Console.WriteLine("even number is {0}",evenNumber);
				evenNumber=evenNumber+2;
			}
		}
		public  static void addNumber(int a,int b){
			int number=a+b;
			
				Console.WriteLine("even number is {0}",number);
				
			
		}
		public static void passByValue(int i){
			i=10;
		}
		public static void passByRef(ref int i){
			i=10;
		}
		public static void calculate(int a,int b,out int sum,out int product){
			sum=a+b;
			product=a*b;
		}
		public static void parammCal(params int []a){
			foreach(int i in a){
				Console.WriteLine("element is {0}",i);
			}
		}
			
	}
