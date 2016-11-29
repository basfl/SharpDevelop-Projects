/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 6/14/2015
 * Time: 1:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Nullable
{
	
	class Program
	{
		enum Days {Sat, Sun, Mon, Tue, Wed, Thu, Fri};
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			Console.WriteLine("enum is {0}",Days.Sat);
			// like if we have field that are optionals 
			int ?i=null;
			bool ?areYouMajor=null;
			if(areYouMajor==true){
				Console.WriteLine("you are major");
			}
			else if(areYouMajor==false){
				Console.WriteLine("you are NOT a major");
			}
			else{
				Console.WriteLine("user did not answer");
			}
			
			convertNullableToInt();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		private static void convertNullableToInt(){
			int ?ticketOnSell=100;
			int availableTicket;
			if(ticketOnSell==null){
				availableTicket=0;
			}
			else{
				availableTicket=ticketOnSell.Value;
			}
			Console.WriteLine("available ticket is {0}",availableTicket);
			// this is alternative to if-else  ?? =if ticketOnSell==null then 0;
			int alter=ticketOnSell ?? 0;
			Console.WriteLine("available ticket is {0}",alter);
		}
		
	}
}