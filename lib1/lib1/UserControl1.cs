/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 3/25/2015
 * Time: 2:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace lib1
{
	/// <summary>
	/// Description of UserControl1.
	/// </summary>
	public partial class UserControl1 : UserControl
	{
		int a;
		int b;
		public UserControl1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public int add(int a,int b){
			return (a+b);
		}
	}
}