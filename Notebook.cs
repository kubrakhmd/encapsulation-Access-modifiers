using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers_encapsulation
{
    internal class Notebook : Product
    {

        private string _opSystem;
        private string _processor;
        private bool _hasGraphicCard;


        public Notebook(string brandName, string model, decimal price, decimal cost, string opSystem, string processor, bool hasGraphicCard = false)
       : base(brandName, model, price, cost, 0)
        {
            _hasGraphicCard = hasGraphicCard;
            _opSystem = opSystem;
            _processor = processor;



        }
        public string GetOpSystem
        {
            get { return _opSystem; }

            set { _opSystem = value; }


        }
        public string Processor
        {
            get { return _processor; }
            set { _processor = value; }
        }
        public bool HasGraphicCard
        {
            get { return _hasGraphicCard; }
            set { _hasGraphicCard = value; }



        }
    }
}

