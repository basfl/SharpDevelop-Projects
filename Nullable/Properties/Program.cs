/*
 * Created by SharpDevelop.
 * User: babak
 * Date: 7/4/2015
 * Time: 11:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;


public class Student{
	private int id;
	private string name;
//	private string passMark;
//	public void setId(int id1){
//		if(id1<0){
//			throw new Exception("should not be negative");
//		}else{
//			this.id=id1;
//		}
//	}
//	public int getId(){
//		return id;
//	}
	public string Email{
		get;
		set;
	}
	public string PassMark{
		get;
		set;
	}
	public int Id{
		set{
			if(value<10){
				Console.WriteLine("negative");
			}
			else{
				this.id=value;
			}
		}
		get{
			return this.id;
		}
	}
	public string Name{
		set{
			this.name=value;
		}
		get{
			return this.name;
		}
	}
}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Student st=new Student();
		//	st.setId(10);
//			st.name=null;
//			st.passMark="pm";
		st.Id=12;
		st.Name="babak";
		st.PassMark="slf";
		st.Email="@g.com";
		Console.WriteLine("id is {0} ",st.Id);
		Console.WriteLine("name is {0} ",st.Name);
		Console.WriteLine("passMark is {0} ",st.PassMark);
		Console.WriteLine("Email is {0} ",st.Email);
			string s1="hi";
			string s2="hi";
				if(s1.Equals(s2)){
				Console.WriteLine("ok");
			}
			if(s1==s2){
				Console.WriteLine("****** OK");
			}
			
			Console.ReadKey(true);
		}
	}
