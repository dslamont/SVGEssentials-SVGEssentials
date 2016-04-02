using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGEssentials.Models.Examples
{
    public interface IExample
    {
        string Ref { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        string FilePath { get;  }
        string HelpText { get; set; }
    }
}
