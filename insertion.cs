/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: insertion.cs                      
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
			int j=i;
			while( j>0 && inp[j-1]>inp[j] )
			{
				int tmp = inp[j-1];
				inp[j-1]=inp[j];
				inp[j--]=tmp;
			}
		}
		Console.Write("Output: ");
		for(int i=0;i<inp.Length;i++)Console.Write("{0} ",inp[i]);
	}
}
