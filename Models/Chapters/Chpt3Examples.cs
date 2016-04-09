using SVGCore;
using SVGCore.Elements;
using SVGEssentials.Chapters;
using SVGEssentials.Models.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SVGEssentials.Models.Chapters
{
    public class Chpt3Examples :IChapter
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Dictionary<string, IExample> Examples { get; set; }

        #region "Construction/Instantiation"

        /// <summary>
        /// Constructor
        /// </summary>
        public Chpt3Examples()
        {
            //Set up Chapter details
            Id = "chapter-3";
            Title = "Chapter 3";
            Description = "Coordinates";

            //Set up the examples for this Chapter
            CreateExamples();
        }

        #endregion

        #region "Examples"

        /// <summary>
        /// Creates the examples to display for this Chapter
        /// </summary>
        private void CreateExamples()
        {
            //Create the storage area for the chapter examples
            Examples = new Dictionary<string, IExample>();

            //Add example 1
            IExample example1 = Example_3_1();
            Examples.Add(example1.Ref, example1);

            
        }

        /// <summary>
        /// Returns the requested example
        /// </summary>
        /// <param name="exampleRef"></param>
        /// <returns>The requested example. If the example cannot be found a NullExample is returned</returns>
        public IExample GetExample(string exampleRef)
        {
            //Create the example to return
            IExample example = new NullExample();

            //Ensure this chapter's examples have been set up
            if (Examples != null)
            {
                //If the specified example exists then retrieve it
                if (Examples.ContainsKey(exampleRef))
                {
                    //Get the specified example
                    example = Examples[exampleRef];
                }
            }

            //Return the example
            return example;
        }

        #region "Example 1"

        /// <summary>
        /// Creates Example 3.1
        /// </summary>
        /// <returns>Example 3.1</returns>
        public IExample Example_3_1()
        {
            Example example = new Example();

            //Set details
            example.Ref = "example-1"; ;
            example.Title = "Chapter 3 - Example: 1";
            example.Description = "This is Example 1";
            example.HelpText = "Using Default Coordinates";

            //Specifiy the method to create the SVG file
            example.CreateFileDelegate = Create_Example_3_1_SVG;

            //Return the example details
            return example;
        }

        /// <summary>
        /// Creates the SVG file for Example 3.1
        /// </summary>
        /// <returns>The path to the created SVG file</returns>
        public string Create_Example_3_1_SVG()
        {
            //Set path to save the file to
            string filePath = @"~/Files/chpt_03_ex_01.svg";

            //Create the SVG Document
            SVGDocument svgDoc = new SVGDocument();
            svgDoc.Width = 200;
            svgDoc.Height = 200;

            //Set details 
            //svgDoc.Title = "Using Default Coordinates";
            //svgDoc.Description = "Using Default Coordinates";

            //Create the Rect
            SvgRect rect = new SvgRect(10, 10, 50, 30);

            //Set the rect styles
            rect.Styles.AddStyle("stroke", "black");
            rect.Styles.AddStyle("fill", "none");

            //Add the rect
            svgDoc.AddChild(rect);

            //Save the SVG document to file
            svgDoc.Render(HttpContext.Current.Server.MapPath(filePath));

            //Return the path to the created file
            return filePath;
        }

        #endregion

        #endregion

    }
}