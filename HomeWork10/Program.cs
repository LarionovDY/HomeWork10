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
            Console.WriteLine("Введите пожалуйста значение угла в градусах, минутах, секундах");
            Console.WriteLine("Градусы:");
            int grad = int.Parse(Console.ReadLine());
            Console.WriteLine("Минуты:");
            int minute = int.Parse(Console.ReadLine());
            Console.WriteLine("Секунды:");
            int second = int.Parse(Console.ReadLine());
            var angle = new Angle(grad, minute, second);
            double radian = angle.ToRadian();            
            Console.WriteLine($"Косинус введенного угла: {Math.Cos(radian):f3}, синус: {Math.Sin(radian):f3}");            
            Console.ReadKey();
        }
    }    
}
