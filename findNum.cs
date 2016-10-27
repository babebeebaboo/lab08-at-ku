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
        findnum(1, digit,inp);
        findnum(10, tendigit,inp);
        findnum(100, hundreddigit,inp);
        return 0;
	}
    static void findnum(int what,int[] digit,int[] inp)
    {
        bool haveans = false;
        int mod;
        if (what == 1)  Console.Write("Digit = {");
        else if (what == 10)  Console.Write("Ten Digit = {");
        else if (what == 100)  Console.Write("Hundred Digit = {");
        string di = "";
        for (int i = 0; i < 10; i++)
        {
            if (digit[i] > 1)
            {
                string ans = " {";
                for (int j = 0; j < inp.Length; j++)
                {
                    if (what == 1) { if (inp[j] % 10 == i) ans = ans + Convert.ToString(inp[j]) + ","; }
                    else if(what == 10) { if (inp[j] % 100 / 10 == i) ans = ans + Convert.ToString(inp[j]) + ","; }
                    else if (what == 100) { if (inp[j] / 100 == i) ans = ans + Convert.ToString(inp[j]) + ","; }
                }
                ans = ans.Remove(ans.Length - 1) + "} ,";
                di = di + ans;
                haveans = true;
            }
        }
        if (haveans) di = di.Remove(di.Length - 2, 2);
        Console.WriteLine("{0}{1}"di," }");
    }
}
