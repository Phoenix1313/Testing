using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good afternoon.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
        }
    }
}