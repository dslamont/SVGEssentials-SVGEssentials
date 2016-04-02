using SVGEssentials.Models.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SVGEssentials.Chapters
{

    /// <summary>
    /// Interface for Chapters
    /// </summary>
    public interface IChapter
    {
        string Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }

        Dictionary<string, IExample> Examples { get; set; }

        IExample GetExample(string exampleRef);
        
    }
}