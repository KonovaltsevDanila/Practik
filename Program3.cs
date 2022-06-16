using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3
{
    class Converter
    {
        double _usd;
        double _eur;
        double _rub;
        //double _uah;

        public Converter(double usd, double eur, double rub)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;

        }

        public double ConvertUAHtoCrrencu(double sum, string currency)
        {
            switch (currency)
            {
                case( "usd"):
                    {
                        return Convert.ToDouble(sum * _usd);
                    }
                case "eur":
                    {
                        return Convert.ToDouble(sum * _eur);
                    }
                case "rub":
                    {
                        return Convert.ToDouble(sum * _rub);
                    }
                default:
                    {
                        return -1;
                    }
                    break;
            }

        }
        public double ConvrtCurtoUAH(double sum, string currency)
        {
            switch (currency)
            {
                case ("usd"):
                    {
                        return Convert.ToDouble(sum / _usd);
                    }
                case "eur":
                    {
                        return Convert.ToDouble(sum / _eur);
                    }
                case "rub":
                    {
                        return Convert.ToDouble(sum / _rub);
                    }
                default:
                    {
                        return -1;
                    }
                    break;
            }
        }


    }




    class Program3
    {
        static void Main(string[] args)
        {

            Converter converter = new Converter(0.034, 0.032, 1.93);
            double aaa = converter.ConvertUAHtoCrrencu(1000, "rub");
            double bbb = converter.ConvrtCurtoUAH(1000, "rub");
            Console.WriteLine(aaa);
            Console.WriteLine(bbb);
            Console.ReadKey();
        }
    }
}
