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
	/// Description of PartialDemoOne.
	/// </summary>
	public  partial class Demo
	{
		private string firstName;
		private string lastName;
		public string FirstName{
			get{return firstName;}
			set{firstName=value;}
		}
		public string LastName{
			get{return lastName;}
			set{ lastName=value;}
		}
	}
}
