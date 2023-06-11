using System;

//lin ref:https://www.youtube.com/watch?v=3IReFdq5d7o&list=PLV7gcRAhaSFvl9u1Cup5DhYMEo8uyi7-r&index=1
/*
 * 1. "==" compares object references.
 * 2. ".Equals()" compares object contents.
 * 3. String datatypes always does content comparison.
 */

namespace interviewQuestion_DifferenceBetween_equalequal_VS_dotEquals
{
    class Program
    {
        static void Main(string[] args)
        {         //ref       //content
            //object o = ".NET Interview questions";
            //object o1 = o; // same ref and content
            //object o1 = new string(".NET Interview questions".ToCharArray()); // different ref but same content

            string o = ".NET Interview questions";
            string o1 = new string(".NET Interview questions".ToCharArray()); // same ref and content

            Console.WriteLine(o == o1); // == ref the same
            Console.WriteLine(o.Equals(o1)); // .Equals contents the same
            Console.ReadLine();
        }
    }
}