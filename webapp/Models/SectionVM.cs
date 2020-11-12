using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapp.Models
{
    public class SectionVM
    {
        public int SectionID { get; set; }
        public string SectionName { get; set; }
        public string SectionFormattedHTML { get; set; }
        public string SectionNonFormattedHTML { get; set; }
        public int PageID { get; set; }
    }
}