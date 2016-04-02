using SVGEssentials.Models.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SVGEssentials.Chapters
{
    /// <summary>
    /// Null Chapter
    /// </summary>
    /// <remarks>Used to indicate no Chapter found</remarks>
    public class NullChapter : IChapter
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Dictionary<string, IExample> Examples { get; set; }

        #region "Constructor"

        public NullChapter()
        {
            Id = String.Empty;
            Title = "No Chapter Found";
            Description = "No Description";
            Examples = new Dictionary<string, IExample>();
        }

        #endregion

        public IExample GetExample(string exampleRef)
        {
            IExample example = new NullExample();

         
            return example;
        }
    }
}