/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: bubble.cs                         
//DATE: 20 Oct 2016                          
/////////////////////////////////////////////
using System;
class test
{
	static void Main()
	{
		Console.Write("Input: ");
		string str = Console.ReadLine();
		string[] inpp = str.Split(' ');
		int[] inp = new int[inpp.Length];
		for(int i=0;i<inpp.Length;i++)inp[i] =Convert.ToInt32( inpp[i]);
		for(int i=0;i<inp.Length;i++)
		{
			for(int j=i;j>=0;j--)
			{
				if(inp[i]>inp[j])
				{
					int tmp = inp[i];
					inp[i]=inp[j];
					inp[j]=tmp;
					break;
				}
			}
		}
		Console.Write("Output: ");
		for(int i=0;i<inp.Length;i++)Console.Write("{0} ",inp[i]);
	}
}
