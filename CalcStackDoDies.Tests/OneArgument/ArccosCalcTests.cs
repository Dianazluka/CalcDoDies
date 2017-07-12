﻿using System;
using CalcStackDoDies.OneArgument;
using NUnit.Framework;

namespace CalcStackDoDies.Tests.OneArgument
{
    [TestFixture]
    public class ArccosCalcTests
    {
        [TestCase(1, 0)]
        [TestCase(-1, Math.PI)]
        [TestCase(0, Math.PI / 2)]
        public void DivCalcTest(double first, double expected)
        {
            var calc = new ArccosCalc();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}
