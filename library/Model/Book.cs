using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace library.Model
{
    public class Book
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public DateTime PublishDate { get; set; }
        public int CountOfPages { get; set; }
        public Place Place { get; set; }
        public UsageCategory UsageCategory { get; set; }
        public decimal Cost { get; set; }
    }
}
