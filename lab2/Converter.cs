using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Converter
    {
        private double usdRate;
        private double eurRate;
        private double plnRate;

        public Converter(double usd, double eur, double pln)
        {
            usdRate = usd;
            eurRate = eur;
            plnRate = pln;
        }

        public double ConvertToUah(double val, string currency)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return val * usdRate;
                case "eur":
                    return val * eurRate;
                case "pln":
                    return val * plnRate;
                default:
                    Console.WriteLine("Помилка, перевірте коректність введених даних");
                    return 0.0;
            }
        }
        public double ConvertFromUah(double val, string currency)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return val / usdRate;
                case "eur":
                    return val / eurRate;
                case "pln":
                    return val / plnRate;
                default:
                    Console.WriteLine("Помилка, перевірте коректність введених даних");
                    return 0.0;
            }
        }
    }
}
