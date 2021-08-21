using System;
using System.Collections.Generic;

namespace ClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //GenerateStock1Data();
            //GenerateReport1Data();
        }

        public static void GenerateReport1Data()
        {
            var report1 = new Report1
            {
                ReportUid1 = Guid.NewGuid().ToString(),
                Header1 = {
                    ReportName1 = "Report1",
                    Date = DateTime.Now
                }
            };
            report1.Body1.LineItems1.Add(new LineItem1()
            {
                PartNumber1 = 1,
                PartDesc1 = "Description1",
                ItemPrice1 = 1.00M,
                Quantity1 = 2
            });
            report1.Body1.LineItems1.Add(new LineItem1()
            {
                PartNumber1 = 2,
                PartDesc1 = "Description2",
                ItemPrice1 = 2.00M,
                Quantity1 = 2
            });

            report1.CalculateFooterTotals1();

            DisplayReport1Data(report1);
        }

        private static void DisplayReport1Data(Report1 report1)
        {
            Console.WriteLine("Header");            
            Console.WriteLine("ReportName: " + report1.Header1.ReportName1);
            Console.WriteLine("Date: " + report1.Header1.Date);
            Console.WriteLine("");

            Console.WriteLine("Items");            
            foreach (var lineItem in report1.Body1.LineItems1)
            {                
                Console.WriteLine("PartNumber: " + lineItem.PartNumber1 + " | " +
                    "PartDesc: " + lineItem.PartDesc1 + " | " +
                    "ItemPrice: " + lineItem.ItemPrice1 + " | " +
                    "Quantity: " + lineItem.Quantity1 + " | " +
                    "Total: " + lineItem.Total1
                    );                
            }

            Console.WriteLine("");
            Console.WriteLine("Footer");
            Console.WriteLine("TotalItems1: " + report1.Footer1.TotalItems1 + " | " + "TotalPrice1: " + report1.Footer1.TotalPrice1);            
        }

        public static void GenerateStock1Data()
        {
            List<Stock1> stock1 = new List<Stock1>();
            stock1.Add(new Stock1()
            {
                Symbol = "NKE",
                TSD =
                {
                    new TimeSeriesDaily(){Date = DateTime.Parse("2021-01-01"), Open = 1.00M, Close = 2.00M },
                    new TimeSeriesDaily(){Date = DateTime.Parse("2021-01-02"), Open = 2.00M, Close = 3.00M },
                    new TimeSeriesDaily(){Date = DateTime.Parse("2021-01-03"), Open = 3.00M, Close = 4.00M }
                }
            });
            stock1.Add(new Stock1()
            {
                Symbol = "TSLA",
                TSD = {
                    new TimeSeriesDaily() {Date = DateTime.Parse("2021-01-01"), Open = 22.05M, Close = 25.98M},
                    new TimeSeriesDaily() {Date = DateTime.Parse("2021-01-02"), Open = 25.98M, Close = 23.02M},
                    new TimeSeriesDaily() {Date = DateTime.Parse("2021-01-03"), Open = 23.02M, Close = 33.93M}
                }
            });

            DisplayStock1Data(stock1);
        }

        private static void DisplayStock1Data(IEnumerable<Stock1> stock1)
        {
            foreach (var s1 in stock1)
            {
                Console.WriteLine("");                
                Console.WriteLine("Time Series Daily " + "(" + s1.Symbol + ")");
                foreach (var t1 in s1.TSD)
                {
                    Console.WriteLine("Date: " + t1.Date + " | " + "Open: " + t1.Open + " | " + "Close: " + t1.Close);
                }
            }            
        }
    }
}
