using SVGEssentials.Models.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SVGEssentials.Models.Examples
{
    public class Example : IExample
    {
        public string Ref { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
        
        public string HelpText { get; set; }

        public Func<string> CreateFileDelegate;

        public string FilePath
        {
            get
            {
                string filePath = String.Empty;

                if(CreateFileDelegate != null)
                {
                    filePath = CreateFileDelegate.Invoke();
                }

                return filePath;
            }
        }

    }
}