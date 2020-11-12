using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapp.Models
{
    public class LibraryVM
    {
        public int LibraryID { get; set; }
        public string Name { get; set; }
        public string LibrarySrc { get; set; }
        public int LibraryType { get; set; }
        public int PageID { get; set; }

    }
}