/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 11/15/2016
 * Time: 1:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace Exception_example
{
	[TestFixture]
	public class Test1
	{
		[Test]
		public void TestMethod()
		{
			//Program p=new Program();
			A a=new A();
			a.f();
			
		}
	}
}
