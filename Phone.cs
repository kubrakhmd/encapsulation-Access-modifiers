using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers_encapsulation
{
    internal class Phone :Product
    {
        private string _ram;
        private string _color;
        private decimal _balance;

        public Phone(string brandName, string model, decimal price, decimal cost, string ram, string color = "Black")
         : base(brandName, model, price, cost, 0)
        {
            _ram = ram;
            _color = color;
            _balance = 0;
        }
        public string Ram


        {
            get { return _ram; }
            set
            {
                Ram = value;
            }
        }
        public string Color{
            get {return _color;}
    set{
      Color=value;}}
      public decimal Balance
        {
            get { return _balance; }
            set { Balance = 0; }


        }
        public void Call(int seconds)
        {
            decimal cost = seconds * 0.1m; 
            if (_balance >= cost)
            {
                    Balance -= cost;
                Console.WriteLine("Zeng edildi.");
            }
            else
            {
                Console.WriteLine("Balansinizda kifayet qeder vesait yoxdur.");
            }
        }

        public void Pay(decimal money)
        {
            if (money > 0)
            {
                Balance += money;
            }
            
        }
    }
}

