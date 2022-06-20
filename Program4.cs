using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4
{



    class Employee
    {
        string _name;
        string _surname;
        public Title _title;



        public Employee(string name, string surname, Title title)
        {
            _surname = surname;
            _name = name;
            _title = title;

        }

        public void gerInfo()
        {
            Console.WriteLine("имя:" + _name + "\n" +
                               "фамилия:" + _surname + "\n" +
                               "Должность:" + _title.ToString() + "\n"
                               );
        }



    }
    public abstract class Title
    {
        public virtual double tax(int tax)
        {

            return tax * 0.01;


        }
        public virtual double getOklad(int staj)
        {

            return staj * 10;


        }




    }

    class Worker : Title
    {
        public override double getOklad(int staj)
        {

            return staj * 10;


        }
    }

    class Manager : Title
    {
        public override double getOklad(int staj)
        {

            return staj * 20;


        }
    }

    class Ditector : Title
    {
        public override double getOklad(int staj)
        {

            return staj * 30;


        }
    }










    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string surname = Console.ReadLine();

            //
            //Employee employee1 = new Employee("Denis", "Denisov", new Worker());
            //Console.WriteLine(employee1._title.getOklad(10));
            //

            int t = -1;
            Console.WriteLine("Выберите должность: \n1.Рабочий\n2.Менеджер\n3.Директор");
            t = Convert.ToInt32(Console.ReadLine());

            switch (t)
            {
                case 1:
                    {
                        Employee employee = new Employee(name, surname, new Worker());
                        Console.WriteLine("Введите стаж");
                        int staj = Convert.ToInt32(Console.ReadLine());
                        employee.gerInfo();
                        Console.WriteLine("оклад:"+employee._title.getOklad(staj));
                        Console.WriteLine("налог:" + employee._title.tax(13) * employee._title.getOklad(staj));

                        break;
                    }
                case 2:
                    {
                        Employee employee = new Employee(name, surname, new Manager());
                        Console.WriteLine("Введите стаж");
                        int staj = Convert.ToInt32(Console.ReadLine());
                        employee.gerInfo();
                        Console.WriteLine("оклад:" + employee._title.getOklad(staj));
                        Console.WriteLine("налог:" + employee._title.tax(13) * employee._title.getOklad(staj));

                        break;
                    }
                case 3:
                    {
                        Employee employee = new Employee(name, surname, new Ditector());
                        Console.WriteLine("Введите стаж");
                        int staj = Convert.ToInt32(Console.ReadLine());
                        employee.gerInfo();
                        Console.WriteLine("оклад:" + employee._title.getOklad(staj));
                        Console.WriteLine("налог:" + employee._title.tax(13) * employee._title.getOklad(staj));

                        break;
                    }
            }




            Console.ReadKey();
        }
    }
}
