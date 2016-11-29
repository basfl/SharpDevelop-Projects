/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 11/20/2016
 * Time: 3:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PartialMethodExample
{
	/// <summary>
	/// Description of DemoPartial1.
	/// </summary>
	public  partial class PartialOne
	{
		
		 partial void partialMethodDisplay(){
			Console.WriteLine("partial method invoked");
		}
	}
}
