using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConsoleApplication2
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
  
    public class TestA
    {
        [Fact]
        public void Test()
        {

            Assert.True(1>0);
        }
    } 
    public class TestB
    {
        [Fact]
        public void Test()
        {

            Assert.True(1>0);
        }
    }
    public class TestC
    {
        [Fact]
        public void Test()
        {

            Assert.True(1>0);
        }
    }
}
