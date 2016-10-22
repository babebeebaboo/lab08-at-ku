/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: findNum.cs                        
//DATE: 21 Oct 2016                          
/////////////////////////////////////////////
using System;
class test
{
	static int Main()
	{
		Console.Write("Set: ");
		string inpp = Console.ReadLine();
		string[] inppp = inpp.Split(' ');
		int[] inp = new int[inppp.Length];
		for(int i=0;i<inppp.Length;i++)inp[i] = Convert.ToInt32(inppp[i]);

		Array.Sort(inp);
		int[] digit = new int[10];
		int[] tendigit = new int[10];
		int[] hundreddigit = new int[10];
		bool error=false;
		for(int i=0;i<inp.Length;i++)
		{
			digit[inp[i]%10]++;
			tendigit[inp[i]%100/10]++;
			hundreddigit[inp[i]%1000 /100]++;
			if(inp[i] < 100)error=true;
		}
		if(error){
			Console.WriteLine("Input Error");
			return 0;
		}

		bool haveans=false;
		Console.Write("Digit = {");
		string di ="";
		for(int i=0;i<10;i++)
		{
			if(digit[i]>1)
			{
				string ans="";
				ans = ans+" {";
				for(int j=0;j<inp.Length;j++)if(inp[j]%10 == i)ans=ans+Convert.ToString(inp[j])+",";
				ans=ans.Remove(ans.Length-1);
				ans=ans+"} ,";
				di=di+ans;
				haveans=true;
			}
		}
		if(haveans)di = di.Remove(di.Length-2,2);
		Console.Write(di);
		Console.WriteLine(" }");
		haveans=false;
		string hdi ="";
		Console.Write("Ten Digit = {");
		for(int i=0;i<10;i++)
		{
			if(tendigit[i]>1)
			{
				string ans="";
				ans = ans+" {";
				for(int j=0;j<inp.Length;j++)if(inp[j]%100/10 == i)ans=ans+Convert.ToString(inp[j])+",";
				ans=ans.Remove(ans.Length-1);
				ans=ans+"} ,";
				hdi=hdi+ans;
				haveans=true;
			}
		}
		if(haveans)hdi = hdi.Remove(hdi.Length-2,2);
		Console.Write(hdi);
		Console.WriteLine(" }");
		string hudi="";
		haveans=false;
		Console.Write("Hundred Digit = {");
		for(int i=0;i<10;i++)
		{
			if(hundreddigit[i]>1)
			{
				string ans="";
				ans = ans+" {";
				for(int j=0;j<inp.Length;j++)if(inp[j]/100 == i)ans=ans+Convert.ToString(inp[j])+",";
				ans=ans.Remove(ans.Length-1);
				ans=ans+"} ,";
				hudi=hudi+ans;
				haveans=true;
			}
		}
		if(haveans)hudi = hudi.Remove(hudi.Length-2,2);
		Console.Write(hudi);
		Console.WriteLine(" }");
		return 0;
	}
}
