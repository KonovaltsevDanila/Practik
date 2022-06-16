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

        

       public Employee(string name, string surname, Title title )
        {
            _surname = surname;
            _name = name;

        }


      public abstract  class Title
        {




        }

        class Worker : Title
        {
               
        }









    }



    class Program4
    {
        static void Main(string[] args)
        {

        }
    }
}
