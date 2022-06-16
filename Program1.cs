using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_konovaltsev
{

    /*
     Задание 1:
            Используя Visual Studio, создайте проект по шаблону Console Application.
            Требуется: Создать класс с именем Rectangle.
            В теле класса создать два поля, описывающие длины сторон double side1, side2.
            Создать пользовательский конструктор Rectangle(double side1, double side2), в
            теле которого поля side1 и side2 инициализируются значениями аргументов.
            Создать два метода, вычисляющие площадь прямоугольника - double
            AreaCalculator() и периметр прямоугольника - double PerimeterCalculator().
            Создать два свойства double Area и double Perimeter с одним методом доступа get.
            Написать программу, которая принимает от пользователя длины двух сторон
            прямоугольника и выводит на экран периметр и площадь.
     
     
     */




    class Rectangle
    {
        double _side1;
        double _side2;

        public double area { get { return AreaCalculator(); } }

        public double perimeter { get { return PerimeterCalculator(); } }

        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }


        private double AreaCalculator()
        {

            return _side1 * _side2;
        }
        private double PerimeterCalculator()
        {


            return 2 * _side1 + 2 * _side2;
        }

    }


    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны прямоугольника");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());


            Rectangle rectangle = new Rectangle(x, y);
            Console.WriteLine(rectangle.area);
            Console.WriteLine(rectangle.perimeter);
            Console.ReadKey();
        }

    }
}
