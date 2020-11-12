using RazorEngine.Compilation.ImpromptuInterface.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webapp.Infrastructure
{
    public static class RazorParser
    {
        public static string Parse(this HtmlHelper helper, string dataToParse, object item)
        {
            
            return helper.Raw(dataToParse).ToHtmlString();
        }
    }
}