﻿namespace CalcStackDoDies.OneArgument
{
    public class CosgradClas : OneArgument.IOneArgumentsCalculator
    {
        public double Calculate(double first)
        {
            var converter = new GradToRadConverter();
            var calculator = new CosCalc();
            return calculator.Calculate(converter.Calculate(first));
        }
    }
}

   