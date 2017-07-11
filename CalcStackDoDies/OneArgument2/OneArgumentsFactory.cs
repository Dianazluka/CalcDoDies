﻿using System;
using CalcStackDoDies.OneArgument;

namespace CalcStackDoDies.OneArgument2
{
    public static class OneArgumentsFactory
    {
        public static OneArgument.IOneArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Sin":
                    return new SinCalc();
                case "Cos":
                    return new CosCalc();
                case "Tan":
                    return new TanClas();
                case "Ctan":
                    return new CtanCalc();
                case "Exp":
                    return new ExpCalc();
                case "In":
                    return new InCalc();
                case "Sqr":
                    return new SqrCalc();
                case "Twoinx":
                    return new OneArgument.TwoinxCalc();
                case "Modul":
                    return new ModulCalc();
                case "Onedivx":
                    return new OnedivxCalc();
               default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}