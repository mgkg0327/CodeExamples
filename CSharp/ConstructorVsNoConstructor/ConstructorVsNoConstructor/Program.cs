using System;

namespace ConstructorVsNoConstructor
{
    public class Book1
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    public class Book2
    {
        public string Title { get; set; }
        public string Author { get; set; }


        public Book2(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book1 b1 = new Book1();
            b1.Title = "Some Title1";
            b1.Author = "Some Author1";

            Book2 b2 = new Book2("Some Title2", "Some Author2");

            

            Console.WriteLine(b1.Title +", "+ b1.Author);
            Console.WriteLine(b2.Title + ", " + b2.Author);
        }
    }
}

