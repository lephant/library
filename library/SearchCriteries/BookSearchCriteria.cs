using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using library.Model;

namespace library.SearchCriteries
{
    public class BookSearchCriteria
    {
        public string Text { get; set; }
        public List<Author> Authors { get; set; }
        public List<Publisher> Publishers { get; set; }
        public List<Place> Places { get; set; }
        public List<UsageCategory> UsageCategories { get; set; }
    }
}
