/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 11/20/2016
 * Time: 3:07 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PartialMethodExample
{
	/// <summary>
	/// Description of DemoPartial.
	/// </summary>
	public  partial class PartialOne
	{
		
		 partial void partialMethodDisplay();
		public void f(){
			Console.WriteLine("method f is invoke");
			partialMethodDisplay();
		}
	}
}
