using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Program8 : MonoBehaviour
{
    public Program8()
    {
    }
}

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);
        }
    }
    namespace MyApplication
    {
        class Program
        {
            static void Main(string[] args)
            {
                string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
                for (int i = 0; i < cars.Length; i++)
                {
                    Console.WriteLine(cars[i]);
                }
            }
        }
    }
}
