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
                    Console.WriteLine("Некорректный ввод, значение должно составлять от 0 до 59, присвоено значение по умолчанию (0).");
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
                    Console.WriteLine("Некорректный ввод, значение должно составлять от 0 до 59, присвоено значение по умолчанию (0).");
                }
            }
        }
        public Angle()
        {
            grad = 0;
            minute = 0;
            second = 0;
        }
        private Angle(int grad, int minute, int second)
        {
            this.grad = grad;
            this.minute = minute;
            this.second = second;
        }
        public double ToRadian(int grad, int minute, int second)
        {
            double radian = (grad + (double)minute / 60 + (double)second / 3600) * Math.PI / 180;
            Console.WriteLine($"Значение угла в радианах: {radian:f3}");
            return radian;
        }
    }
}
