using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public string myName;
    // Start is called before the first frame update
    // Use this for initialization
    void Start()
    {
        Debug.Log("I am alive and my name is " + myName);
    }
}

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            Console.WriteLine(name);
        }
    }

    internal class Console
    {
        internal static void WriteLine(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
