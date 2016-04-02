using SVGEssentials.Models.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SVGEssentials.Models.Examples
{
    public class NullExample : IExample
    {
        public string Ref { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FilePath { get;  }
        public string HelpText { get; set; }

        #region "Constructor"

        public NullExample()
        {
            Ref = String.Empty;
            Title = String.Empty;
            Description = String.Empty;
            FilePath = String.Empty;
            HelpText = string.Empty;
        }

        #endregion
    }
}