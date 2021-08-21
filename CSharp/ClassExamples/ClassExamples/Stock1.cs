using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    public class Stock1
    {
        public string Symbol { get; set; }
        public List<TimeSeriesDaily> TSD { get; set; }

        public Stock1()
        {
            TSD = new List<TimeSeriesDaily>();
        }
    }

    //public class StockList1 : IEnumerable<Stock1>
    //{
    //    private List<Stock1> Stocks1;

    //    public IEnumerator<Stock1> GetEnumerator()
    //    {
    //        return Stocks1.GetEnumerator();
    //    }
    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return Stocks1.GetEnumerator();
    //    }
    //}

    public class TimeSeriesDaily
    {
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }
    }
}
