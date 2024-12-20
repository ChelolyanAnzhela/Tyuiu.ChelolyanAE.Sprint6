﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ChelolyanAE.Sprint6.Task4.V13.Lib
{
    public class DataService : ISprint6Task4V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] mas;
            int len = stopValue - startValue + 1;
            mas = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((3 * x + 2) - ((2 * x - (x)) / (Math.Cos(x) + 1)), 2);
                mas[count] = y;
                count++;
            }
            return mas;
        }
    }
}
