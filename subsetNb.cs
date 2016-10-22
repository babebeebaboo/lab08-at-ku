/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: subsetNb.cs                       
//DATE: 20 Oct 2016                          
/////////////////////////////////////////////
/////////////////////////////////////////////
﻿using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("subsetNumber: ");
            string aa = Console.ReadLine();
            string[] inp = aa.Split(' ');
            bool[] number = new bool[100];
            for(int i=0;i<inp.Length;i++)
            {
                if(Convert.ToInt32(inp[i])<100)
                    number[Convert.ToInt32(inp[i])] = true;
                for (int j= 0; j < inp.Length; j++)
                {
                    if(Convert.ToInt32(inp[j]) + Convert.ToInt32(inp[i]) <100)
                    number[Convert.ToInt32(inp[j]) + Convert.ToInt32(inp[i])] = true;
                }
            }
            for (int i = 0; i < 100; i++) if (number[i]) Console.Write("{0} ", i);
        }
    }
}
