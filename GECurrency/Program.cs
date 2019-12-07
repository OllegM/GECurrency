using System;
using System.Collections.Generic;

namespace GECurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            Process();
            Console.ReadLine();
        }

        static async void Process()
        {
            string[] currencies = { "AED", "AMD", "AUD", "AZN", "BGN", "BYR", "CAD", "CHF", "CNY", "CZK", "DKK", "EEK", "EGP", "EUR", "GBP", "HKD", "HUF", "ILS", "INR", "IRR", "ISK", "JPY", "KGS", "KWD", "KZT", "LTL", "LVL", "MDL", "NOK", "NZD", "PLN", "RON", "RSD", "RUB", "SEK", "SGD", "TJS", "TMT", "TRY", "UAH", "USD", "UZS" };

            var client = new GECurrency.NBGCurrencyPortClient();
            //await client.OpenAsync();

            // List<Currency> cResult = new List<Currency>();
            List<CurrencyString> cStringResult = new List<CurrencyString>();

            foreach (var curr in currencies)
            {
                CurrencyString c = new CurrencyString();
                c.Name = curr;
                c.Date = await client.GetDateAsync();
                c.Value = await client.GetCurrencyAsync(curr);
                c.Change = await client.GetCurrencyChangeAsync(curr);
                c.Rate = await client.GetCurrencyRateAsync(curr);
                c.Description = await client.GetCurrencyDescriptionAsync(curr);
                cStringResult.Add(c);
            }

            foreach (var c in cStringResult)
            {
                Console.WriteLine($"{c.Name} {c.Date} {c.Value} {c.Change} {c.Rate} {c.Description}");
            }
        }
    }
}
