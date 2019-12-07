using System;
using System.Collections.Generic;
using System.Text;

namespace GECurrency
{
    public class Currency
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public float Value { get; set; }
        public float Change { get; set; }
        public int Rate { get; set; }
        public String Description { get; set; }

    }

    public class CurrencyString
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Value { get; set; }
        public string Change { get; set; }
        public int Rate { get; set; }
        public string Description { get; set; }

    }
}
