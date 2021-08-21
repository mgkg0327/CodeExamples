using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    public class Report1
    {
        public string ReportUid1 { get; set; }
        public Header1 Header1 { get; set; }
        public Body1 Body1 { get; set; }
        public Footer1 Footer1 { get; set; }

        public Report1()
        {
            Header1 = new Header1();
            Body1 = new Body1();
            Footer1 = new Footer1();
        }

        internal void CalculateFooterTotals1()
        {
            Footer1.TotalItems1 = Body1.LineItems1
                .Sum(x => x.Quantity1);
            Footer1.TotalPrice1 = Body1.LineItems1
                .Sum(x => x.Total1);
        }
    }

    public class Body1
    {
        public List<LineItem1> LineItems1 { get; set; }

        public Body1()
        {
            LineItems1 = new List<LineItem1>();
        }
    }

    public class LineItem1
    {
        public int PartNumber1 { get; set; }
        public string PartDesc1 { get; set; }
        public int Quantity1 { get; set; }
        public decimal ItemPrice1 { get; set; }
        public decimal Total1
        {
            get { return Quantity1 * ItemPrice1; }
        }
    }

    public class Header1
    {
        public string ReportName1 { get; set; }
        public DateTime Date { get; set; }
    }

    public class Footer1
    {
        public int TotalItems1 { get; set; }
        public decimal TotalPrice1 { get; set; }
    }
}
