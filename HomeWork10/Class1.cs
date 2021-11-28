using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    class Angle
    {
        private int grad;
        public int Grad
        {
            get { return grad; }
            set
            {
                if (value >= 0 && value < 360)
                {
                    grad = value;
                }
                else if (value >= 360)
                {
                    grad = value % 360;
                }
            }
        }
        private int minute;
        public int Minute
        {
            get { return minute; }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    minute = value;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод, значение минут должно составлять от 0 до 59. Установлено значение по умолчанию (0)");
                }
            }
        }
        private int second;
        public int Second
        {
            get { return second; }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    second = value;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод, значение секунд должно составлять от 0 до 59. Установлено значение по умолчанию (0)");
                }
            }
        }
        public Angle()
        {
            Grad = 0;
            Minute = 0;
            Second = 0;
        }
        public Angle(int grad, int minute, int second)
        {
            Grad = grad;
            Minute = minute;
            Second = second;
        }
        public double ToRadian()
        {
            double radian = (grad + (double)minute / 60 + (double)second / 3600) * Math.PI / 180;
            Console.WriteLine($"Значение угла в радианах: {radian:f3}");
            return radian;
        }
    }
}
