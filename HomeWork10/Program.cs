using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    //Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
    //Реализовать класс, в котором указанные значения представлены в виде свойств.
    //Для свойств предусмотреть проверку корректности данных.
    //Класс должен содержать конструктор для установки начальных значений,
    //а также метод ToRadians для перевода угла в радианы.Создать объект на основе разработанного класса.
    //Осуществить использование объекта в программе.
    class Program
    {
        static void Main(string[] args)
        {
            var angle = new Angle();            
            Console.WriteLine("Введите пожалуйста значение угла в градусах, минутах, секундах");
            Console.WriteLine("Градусы:");
            angle.Grad = int.Parse(Console.ReadLine());
            Console.WriteLine("Минуты:");
            angle.Minute = int.Parse(Console.ReadLine());
            Console.WriteLine("Секунды:");
            angle.Second = int.Parse(Console.ReadLine());
            double radian = angle.ToRadian(angle.Grad, angle.Minute, angle.Second);
            double cosAngle1 = Math.Cos(radian);
            Console.WriteLine($"Косинус введенного угла: {Math.Cos(radian):f3}, синус: {Math.Sin(radian):f3}");            
            Console.ReadKey();
        }
    }
    
}
