/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 11/19/2016
 * Time: 1:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PartialClasses
{
	/// <summary>
	/// Description of PartialDemoTwo.
	/// </summary>
	public  partial class Demo
	{
		public string fullName(){
			return firstName+" "+lastName;
		}
	}
}
