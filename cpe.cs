/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: cpe.cs                            
//DATE: 21 Oct 2016                          
/////////////////////////////////////////////
﻿
using System;
class test
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        while (true)
        {
            Console.Clear();
            print(n, 0);
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(0.5).TotalMilliseconds);
            Console.Clear();
            print(n, 1);
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(0.5).TotalMilliseconds);
            Console.Clear();
            print(n, 2);
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(0.5).TotalMilliseconds);
            Console.Clear();
            print(n, 3);
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(0.5).TotalMilliseconds);
            Console.Clear();
            print(n, 4);
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(0.5).TotalMilliseconds);
            Console.Clear();
            print(n, 5);
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(0.5).TotalMilliseconds);
            Console.Clear();
            print(n, 6);
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(0.5).TotalMilliseconds);
            Console.Clear();
            print(n, 7);
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(0.5).TotalMilliseconds);
            Console.Clear();
            print(n, 6);
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(0.5).TotalMilliseconds);
            Console.Clear();
            print(n, 5);
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(0.5).TotalMilliseconds);
            Console.Clear();
            print(n, 4);
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(0.5).TotalMilliseconds);
            Console.Clear();
            print(n, 3);
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(0.5).TotalMilliseconds);
            Console.Clear();
            print(n, 2);
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(0.5).TotalMilliseconds);
            Console.Clear();
            print(n, 1);
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(0.5).TotalMilliseconds);

        }
    }
    static void print(int size, int space)
    {
        firstline(size, space);
        Console.WriteLine();
        middleup(size, space);
        middle(size, space);
        Console.WriteLine();
        middledown(size, space);
        lastline(size, space);
    }
    static void middledown(int size, int space)
    {
        for (int i = 0; i < size - 2; i++)
        {
            printspace(size, space);
            for (int j = 0; j <= i; j++) Console.Write(" ");
            for (int j = size - i - 1; j > 0; j--) Console.Write("X");
            Console.Write(" X");
            for (int j = 0; j < size ; j++) Console.Write(" ");
            Console.Write("X");
            for (int j = 0; j < size ; j++) Console.Write(" ");
            Console.Write("X");
            for (int j = 0; j < size ; j++) Console.Write(" ");
            for (int j = size - i - 1; j > 0; j--) Console.Write("X");
            Console.WriteLine();
        }
    }
    static void middle(int size, int space)
    {
        printspace(size, space);

        for (int i = 0; i < size; i++) Console.Write("X");
        Console.Write(" X");
        for (int j = 0; j < size ; j++) Console.Write(" ");
        for (int i = 0; i < size; i++) Console.Write("X");
        Console.Write(" ");
        for (int i = 0; i < size; i++) Console.Write("X");
        Console.Write(" ");
        for (int i = 0; i < size; i++) Console.Write("X");
    }
    static void middleup(int size, int space)
    {
        for (int i = 0; i < size - 2; i++)
        {
            printspace(size, space);
            for (int j = 0; j < size - 2 - i; j++) Console.Write(" ");
            for (int j = 0; j < i + 2; j++) Console.Write("X");
            Console.Write(" X");
            for (int j = 0; j < size ; j++) Console.Write(" ");
            Console.Write("X");
            for (int j = 0; j < size - 2; j++) Console.Write(" ");
            Console.Write("X X");
            for (int j = 0; j < size; j++) Console.Write(" ");
            for (int j = 0; j < i + 2; j++) Console.Write("X");
            Console.WriteLine();
        }
    }
    static void printspace(int size, int space)
    {
        for (int i = 0; i < space * size; i++) Console.Write(" ");
    }
    static void firstline(int size, int space)
    {
        printspace(size, space);
        for (int j = size - 1; j > 0; j--) Console.Write(" ");
        for (int j = 0; j <= 0; j++) Console.Write("X");
        Console.Write(" ");
        for (int j = 0; j < size; j++) Console.Write("X");
        Console.Write(" ");
        for (int j = 0; j < size; j++) Console.Write("X");
        Console.Write(" ");
        for (int j = 0; j < size; j++) Console.Write("X");
        Console.Write(" ");
        for (int j = 0; j <= 0; j++) Console.Write("X");
    }
    static void lastline(int size, int space)
    {
        printspace(size, space);
        for (int j = size - 1; j > 0; j--) Console.Write(" ");
        Console.Write("X ");
        for (int j = 0; j < size; j++) Console.Write("X");
        Console.Write(" X");
        for (int j = 0; j < size ; j++) Console.Write(" ");
        for (int j = 0; j < size; j++) Console.Write("X");
        Console.Write(" ");
        for (int j = 0; j <= 0; j++) Console.Write("X");
    }
}
