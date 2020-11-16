using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace batman2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int age = 17;
            if (age > 14)
            {
                if (age > 18)
                {
                    Console.WriteLine("Adult");
                }
                else
                {
                    Console.WriteLine("Teenager");
                }
            }
            else
            {
                if (age > 0)
                {
                    Console.WriteLine("Child");
                }
                else
                {
                    Console.WriteLine("Something's wrong");
                }
            }
        }

        [TestMethod]
        public void MyTestMethod()
        {
            int a = 10;
            int b = 9;
            if (a > b)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("???");
            }
           
        }



    }
}