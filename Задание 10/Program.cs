using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    /*Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд. 
     *Реализовать класс, в котором указанные значения представлены в виде свойств. 
     *Для свойств предусмотреть проверку корректности данных. Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы. 
     *Создать объект на основе разработанного класса. 
     *Осуществить использование объекта в программе.*/
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle(45, 53, 34);
            angle.ToRadian();
            Console.ReadKey();
        }
    }
    class Angle
    {
        int gradus;
        int min;
        int sec;
        public int Gradus
        {
            set
            {
                if (value != 0)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Задайте ненулевой градус");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value > 0)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Задайте угловые минуты больше нуля");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value > 0)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Задайте угловые секунды больше нуля");
                }
            }
            get
            {
                return sec;
            }
        }
        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public void ToRadian()
        {
            double radian = ((gradus + (min / 60) + (sec / 3600)) * Math.PI) / 180;
            Console.WriteLine("Значение угла в радианах: {0:f3}", radian);
        }
    }
}
