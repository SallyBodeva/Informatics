﻿using System;


public class Program
{
    static void Main()
    {
        for (int i = 1; i <=10 ; i++)
        {
            for (int k = 1; k <= 10; k++)
            {
                Console.WriteLine($"{i} * {k} = {i*k}");
            }
        }
    }
} 

