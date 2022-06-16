using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr5
{
    public class Invoice
    {
        // Модификатор readonly позволяет задавать значение поля только в конструкторе или на уровне класса
        public readonly int Account;
        public readonly string Customer;
        public readonly string Provider;

        // Поля закрыты, соответственно, доступ к ним можно обеспечить либо через свойства, либо задавать им значения в конструкторе
        private string _article = String.Empty;
        private int _quantity;

        public string Article
        {
            get => _article;
            set => _article = value;
        }

        public int Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }

        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public Invoice(int account, string customer, string provider, string article, int quantity) : this(account, customer, provider)
        {
            _article = article;
            _quantity = quantity;
        }

        public double GetAccountWithNds(double nds = 0.2)
        {
            return Account + (Account * nds);
        }

        public void Show()
        {
            Console.WriteLine($" {Customer} заказал у {Provider} {_quantity} {_article} и выставил счет," +
                $"\n который будет составлять {Account} без Ндс, и {GetAccountWithNds()} с Ндс");
        }
    }

    class starter
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1200, "ООО Белые тапочки", "ООО вагонзавод")
            {
                Quantity = 10,
                Article = "Вагонов"
            };
            invoice.GetAccountWithNds();
            invoice.Show();
        }
    }






    class Program5
    {
        static void Main(string[] args)
        {

        }
    }
}
