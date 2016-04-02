using SVGEssentials.Chapters;
using SVGEssentials.Models.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SVGEssentials.Models
{
    public class Book
    {
        public string Title { get; set; }
        public Dictionary<string, IChapter> Chapters { get; set; }

        #region "Constructors"

        public Book()
        {
            //Set up the Chapters storage
            Chapters = new Dictionary<string, IChapter>();

            Title = "SVG Essentials";

            //Add the chapters 
            Chapters.Add("chapter-1", new Chpt1Examples());

        }

        #endregion

        #region "Chapters"

        public IChapter GetChapter(string chapterRef)
        {
            //Set up default return value
            IChapter chapter = new NullChapter();

            if(Chapters.ContainsKey(chapterRef))
            {
                chapter = Chapters[chapterRef];
            }

            return chapter;
        }

        #endregion

        #region "Examples"

        public IExample GetExample(string chapterRef, string exampleRef)
        {
            IExample example = new NullExample();

            IChapter chapter = GetChapter(chapterRef);

            example = chapter.GetExample(exampleRef);

            return example;
        }

        #endregion 
    }
}