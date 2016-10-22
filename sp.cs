/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: sp.cs                             
//DATE: 21 Oct 2016                          
/////////////////////////////////////////////

using System;
class test
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) findparin(i+1);

    }
    static void findparin(int round)
    {
        int[] input = new int[1000001];
        int o = 0;
        while(true)
        {
            int a = Console.Read();
            if (a == '\n') break;
            input[o++] = a-48;
        }
        //Console.WriteLine("INPUT: ");
        //for (int i = 0; i < o; i++) Console.WriteLine(input[i]);
        
        do
        {
            input[o - 1]++;
            int h = 1;
            while (input[o - h] == 10)
            {
                if ( o - h - 1 >= 0 )
                {
                    input[o - h - 1]++;
                    input[o - h] = 0;
                }
                else 
                {
                    for (int j = 0; j < o; j++)
                    {
                        input[j+1] =0;
                    }
                    o++;
                    input[0] = 1;
                }
                h++;
            }
        }
        while (isparin(input, o) == false);

        

        Console.Write("Case #{0}: ", round);
        for (int j = 0; j < o; j++)
        {
            Console.Write("{0}",input[j]);
        }
        Console.WriteLine();
    }
    static bool isparin(int[] input,int length)
    {
        bool parin = true;
        int[] rev = new int[length];
        for(int i = 0; i < length/2; i++)
        {
            if (input[i] != input[length - i - 1])
            {
                parin = false;
                break;
            }
        }
        return parin;
    }
}
