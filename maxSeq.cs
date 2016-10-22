/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: maxSeq.cs                         
//DATE: 22 Oct 2016                          
/////////////////////////////////////////////
using System;
class test
{
    static void Main()
    {
        Console.Write("Input an array: ");
        string a = Console.ReadLine();
        string[] inpp = a.Split(' ');
        int[] inp = new int[inpp.Length];
        for (int i = 0; i < inpp.Length; i++) inp[i] = Convert.ToInt32(inpp[i]);
        int check = 0, max = 0;
        for (int i = 1; i < inp.Length; i++)
        {
            if (inp[i] - inp[i-1] == 1) check++;
            else check = 0;
            if (check > max) max = check;
        }
        check = 0;
        Console.Write("Result: ");
        string[] same = new string[inp.Length];
        int o = 0;
        for (int i = 1; i < inpp.Length; i++)
        {
            string ans = "";
            bool print = true;
            if (inp[i] - inp[i-1] == 1) check++;
            else check = 0;
            if (max == 0 && i==1)
            {
                ans = ans + "{" + Convert.ToString(inp[0]) + "} ";
                same[o++] = ans;
                Console.Write(ans);
                ans = "";
            }
            if (check == max)
            {
                ans = ans + "{";
                for(int j = i - check; j <= i; j++) ans = ans + Convert.ToString(inp[j]) + ",";
                ans=ans.Remove(ans.Length - 1);
                ans = ans + "} ";
                for(int j = 0; j < o; j++)
                {
                    if(same[j] == ans)
                    {
                        print = false;
                        break;
                    }
                }
                if (print)
                {
                    Console.Write(ans);
                    same[o++] = ans;
                }
            }
        }
    }
}
