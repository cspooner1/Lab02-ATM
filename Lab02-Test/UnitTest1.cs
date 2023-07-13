﻿using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Lab02_Test
{

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1, 1);
        }

        decimal ViewBalance()
        {
            return 10m;
        }
        /// <summary>
        /// Test ViewBalance()
        /// ViewBalance should retunr a decimal value
        /// </summary>
        [Theory]
        [InlineData(1)]

        public void TestViewBalance(decimal value)
        {
            Program.Deposit(value);
        }

        [Theory]
        [InlineData(1)]
    }
}