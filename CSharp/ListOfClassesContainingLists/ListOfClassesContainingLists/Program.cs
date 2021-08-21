using System;
using System.Collections.Generic;

namespace ListOfClassesContainingLists
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
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {

            List<Stock> stocks = new List<Stock>();

            stocks.Add(new Stock()
            {
                Symbol = "NKE",
                Market = "NYSE",
                TSD =
                {
                    new TimeSeriesDaily() {
                        Date = DateTime.Parse("2021-01-01"),
                        Open = 20,
                        High = 22,
                        Low = 19,
                        Close = 22
                    },
                    new TimeSeriesDaily() {
                        Date = DateTime.Parse("2021-01-02"),
                        Open = 21,
                        High = 23,
                        Low = 20,
                        Close = 23
                    }
                }
            });

            stocks.Add(new Stock()
            {
                Symbol = "TSLA",
                Market = "NYSE",
                TSD =
                {
                    new TimeSeriesDaily() {
                        Date = DateTime.Parse("2021-01-01"),
                        Open = 20,
                        High = 22,
                        Low = 19,
                        Close = 22
                    },
                    new TimeSeriesDaily() {
                        Date = DateTime.Parse("2021-01-02"),
                        Open = 21,
                        High = 23,
                        Low = 20,
                        Close = 23
                    }
                }
            });


            var symbol = "";
            var market = "";
            DateTime date;
            decimal open;
            decimal high;
            decimal low;
            decimal close;

            foreach (var stock in stocks)
            {
                symbol = stock.Symbol;
                market = stock.Market;

                foreach (TimeSeriesDaily t in stock.TSD)
                {
                    date = t.Date;
                    open = t.Open;
                    high = t.High;
                    low = t.Low;
                    close = t.Close;
                }
            }
        }
    }
}
