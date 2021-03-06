﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToList());
            int[] counts = new int[numbers.Max()+1];
            foreach (var number in numbers)
            {
                counts[number]++;
            }
            for(int i = 0; i < counts.Length; i++)
            {
                if(counts[i] != 0)
                {
                    Console.WriteLine($"{i} -> {counts[i]}");
                }
            }
        }
    }
}
