using Anagram;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests : Program
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            char[] testCharArray = { 'a', 'c', 'e', 'i', 'm', 'n' };
            char[] testOrderedArray = ToOrderedCharArray("iceman");
            Console.WriteLine(testOrderedArray);
            Assert.True(testOrderedArray.ToString() == testCharArray.ToString());
        }
    }
}