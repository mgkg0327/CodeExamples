using System;
using System.Collections.Generic;

namespace ClassWithListOfAttributes
{
    
    public class Stock
    {
        public string Symbol { get; set; }
        public string Market { get; set; }
        public List<TimeSeriesDaily> TSD { get; set; }

        public Stock()
        {
            TSD = new List<TimeSeriesDaily>();
        }
    }

    public class TimeSeriesDaily
    {
        public string thing1 { get; set; }
    }

    
    class Program
    {
        static void Main(string[] args)
        {

            List<Stock> stocks = new List<Stock>();

            stocks.Add(new Stock() {
                Symbol = "NKE",
                Market = "NYSE",
                TSD =
                {
                    new TimeSeriesDaily() {thing1 = "1"},
                    new TimeSeriesDaily() {thing1 = "2"}
                }
            });

            stocks.Add(new Stock()
            {
                Symbol = "TSLA",
                Market = "NYSE",
                TSD =
                {
                    new TimeSeriesDaily() {thing1 = "3"},
                    new TimeSeriesDaily() {thing1 = "4"}
                }
            });


            var Symbol = "";
            var Market = "";
            var Date = "";

            foreach (var stock in stocks)
            {
                Console.WriteLine(stock.Symbol);
                Symbol = stock.Symbol;
                Market = stock.Market;
                
                foreach (TimeSeriesDaily t in stock.TSD)
                {
                    Date = t.thing1;
                    //Console.WriteLine(t.thing1);
                }
            }

            //Console.WriteLine(stocks);
            Console.WriteLine("");
        }
    }
}
