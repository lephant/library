using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace library.Model
{
    public class TableBook
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string PlaceName { get; set; }
        public string UsageCategoryName { get; set; }
        public int CountOfPages { get; set; }
    }
}
