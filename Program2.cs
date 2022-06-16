using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pr2
{/*
  
          Задание 2:
                    Используя Visual Studio, создайте проект по шаблону Console Application.
                    Требуется: Создать классы Point и Figure. Класс Point должен содержать два
                    целочисленных поля и одно строковое поле.
                    Создать три свойства с одним методом доступа get. Создать пользовательский
                    конструктор, в теле которого проинициализируйте поля значениями аргументов.
                    Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти
                    аргументов типа Point.
                    Создать два метода: double LengthSide(Point A, Point B), который рассчитывает
                    длину стороны многоугольника; void PerimeterCalculator(), который рассчитывает
                    периметр многоугольника. Написать программу, которая выводит на экран
                    название и периметр многоугольника.
  */
    //class Point
    //{
    //    public int _a;
    //    public int _b;
    //    string _str;


    //    public Point(int a, int b, string str)
    //    {
    //        _a = a;
    //        _b = b;
    //        _str = str;


    //    }

    //}

    //class Figure
    //{


    //    public Figure(Point p1, Point p2, Point p3)
    //    {
    //        Point _p1 = p1;
    //        Point _p2 = p2;
    //        Point _p3 = p3;
    //    }


    //    private double LengthSide(Point a, Point b)
    //    {
    //        int a2mina = b._a - a._a;
    //        int b2minb = b._b - a._b;

    //        double d = Math.Sqrt(Math.Pow(a2mina, 2) + Math.Pow(b2minb, 2));
    //        //d = √ (x2 - x1)²+(y2 - y1)²)
    //        return d;
    //    }
    //    public void PerimeterCalculator(Point a, Point b, Point c)
    //    {
    //        Console.WriteLine(LengthSide(a, b) + LengthSide(b, c) + LengthSide(c, a));
    //    }

    //    public Figure(Point p1, Point p2, Point p3,Point p4)
    //    {
    //        Point _p1 = p1;
    //        Point _p2 = p2;
    //        Point _p3 = p3;
    //        Point _p4 = p4;

    //    }
    //    public void PerimeterCalculator()
    //    {
    //        Console.WriteLine(LengthSide(_p1, b) + LengthSide(b, c) + LengthSide(c, d) + LengthSide(d, a));
    //    }

    //}











    class Point
    {
        string name;
        int x, y;
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Point()
            : this("", 0, 0) { }
        public Point(string name, int x, int y)
        {
            Console.WriteLine("Введите имя точки:");
            this.name = Console.ReadLine();
            Console.WriteLine("Введите координату X:");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y:");
            this.y = int.Parse(Console.ReadLine());
        }
    }



    class Figure
    {
        int number;
        Point[] points;
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void InitializeFigure()
        {
            Console.WriteLine("Введите количество точек в фигуре");
            number = int.Parse(Console.ReadLine());
            points = new Point[number];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point();
            }

        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 1; i < points.Length; i++)
            {
                perimeter += this.LengthSide(points[i - 1], points[i]);
            }
            perimeter += this.LengthSide(points[0], points[points.Length - 1]);
            return perimeter;
        }
        public Figure(string name)
        {
            InitializeFigure();
        }
    }



    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Point p1 = new Point(3, 5, "qwe");
    //        Point p2 = new Point(4, 1, "qwe");
    //        Point p3 = new Point(2, 2, "qwe");

    //        Figure treugolnik = new Figure(p1, p2, p3);
    //        treugolnik.PerimeterCalculator(p1,p2,p3);
    //        Console.ReadKey();
    //    }
    //}



    class Program2
    {
        static void Main(string[] args)
        {
            Figure cube = new Figure("cube");
            Console.WriteLine(cube.CalculatePerimeter());
            Console.ReadKey();
        }
    }
}
