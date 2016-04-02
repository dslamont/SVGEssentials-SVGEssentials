using SVGEssentials.Models.Examples;
using SVGEssentials.Models;
using SVGFactory;
using SVGFactory.Elements;
using SVGFactory.Operations;
using SVGFactory.Paths;
using System;
using System.Collections.Generic;
using System.Web;

namespace SVGEssentials.Chapters
{
    public class Chpt1Examples : IChapter
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Dictionary<string, IExample> Examples { get; set; }

        #region "Construction/Instantiation"

        /// <summary>
        /// Constructor
        /// </summary>
        public Chpt1Examples()
        {
            //Set up Chapter details
            Id = "chapter-1";
            Title = "Chapter 1";
            Description = "SVG Essentials, Chapter 1";

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
            IExample example1 = Example_1_1();
            Examples.Add(example1.Ref, example1);

            //Add example 2
            IExample example2 = Example_1_2();
            Examples.Add(example2.Ref, example2);

            //Add example 3
            IExample example3 = Example_1_3();
            Examples.Add(example3.Ref, example3);

            //Add example 4
            IExample example4 = Example_1_4();
            Examples.Add(example4.Ref, example4);

            //Add example 5
            IExample example5 = Example_1_5();
            Examples.Add(example5.Ref, example5);

            //Add example 6
            IExample example6 = Example_1_6();
            Examples.Add(example6.Ref, example6);

            //Add example 7
            IExample example7 = Example_1_7();
            Examples.Add(example7.Ref, example7);

            //Add example 8
            IExample example8 = Example_1_8();
            Examples.Add(example8.Ref, example8);
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
            if(Examples != null)
            {
                //If the specified example exists then retrieve it
                if(Examples.ContainsKey(exampleRef))
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
        /// Creates Example 1.1
        /// </summary>
        /// <returns>Example 1.1</returns>
        public IExample Example_1_1()
        {
            Example example = new Example();

            //Set details
            example.Ref = "example-1"; ;
            example.Title = "Chapter 1 - Example: 1";
            example.Description = "This is Example 1";
            example.HelpText = "Basic SVG";

            //Specifiy the method to create the SVG file
            example.CreateFileDelegate = Create_Example_1_1_SVG;

            //Return the example details
            return example;
        }

        /// <summary>
        /// Creates the SVG file for Example 1.1
        /// </summary>
        /// <returns>The path to the created SVG file</returns>
        public string Create_Example_1_1_SVG()
        {
            //Set path to save the file to
            string filePath = @"~/Files/chpt_01_ex_01.svg"; 

            //Create the SVG Document
            SVGDocument svgDoc = new SVGDocument();

            //Set details 
            svgDoc.Title = "Cat";
            svgDoc.Description = "Stick Figure of a Cat";

            //Save the SVG document to file
            svgDoc.Render(HttpContext.Current.Server.MapPath(filePath));

            //Return the path to the created file
            return filePath;
        }

        #endregion

        #region "Example 2"

        /// <summary>
        /// Creates Example 1.2
        /// </summary>
        /// <returns>Example 1.2</returns>
        public IExample Example_1_2()
        {
            Example example = new Example();

            //Set example details
            example.Ref = "example-2"; ;
            example.Title = "Chapter 1 - Example: 2";
            example.Description = "This is Example 2";
            example.HelpText = "Simple Circle";

            //Specifiy the method to create the SVG file
            example.CreateFileDelegate = Create_Example_1_2_SVG;

            //Return the example details
            return example;
        }

        /// <summary>
        /// Creates the SVG file for Example 1.2
        /// </summary>
        /// <returns>The path to the created SVG file</returns>
        public string Create_Example_1_2_SVG()
        {
            //Set the path to save the file to
            string filePath = @"~/Files/chpt_01_ex_02.svg";

            //Create the SVG Document
            SVGDocument svgDoc = new SVGDocument();

            //Set details 
            svgDoc.Title = "Cat";
            svgDoc.Description = "Basic Cat Face";

            //Create the Face
            SvgCircle face = new SvgCircle(70, 95, 50);

            //Set the face styles
            face.Styles.AddStyle("stroke", "black");
            face.Styles.AddStyle("fill", "none");

            //Add the face
            svgDoc.AddChild(face);

            //Save the SVG document to file
            svgDoc.Render(HttpContext.Current.Server.MapPath(filePath));

            //Return the path to the created file
            return filePath;
        }

        #endregion

        #region "Example 3"

        /// <summary>
        /// Creates Example 1.3
        /// </summary>
        /// <returns>Example 1.3</returns>
        public IExample Example_1_3()
        {
            Example example = new Example();

            //Set the example details
            example.Title = "Chapter 1 - Example: 3";
            example.Ref = "example-3"; ;
            example.Description = "This is Example 3";
            example.HelpText = "Cat Face With Single Eye";

            //Set the delegate to create the file
            example.CreateFileDelegate = Create_Example_1_3_SVG;
            
            //Return the example details
            return example;
        }

        /// <summary>
        /// Creates the SVG file for Example 1.3
        /// </summary>
        /// <returns>The path to the created SVG file</returns>
        public string Create_Example_1_3_SVG()
        {
            //Set the path to save the file to
            string filePath = @"~/Files/chpt_01_ex_03.svg";

            //Create the SVG Document
            SVGDocument svgDoc = new SVGDocument();

            //Set details 
            svgDoc.Title = "Cat";
            svgDoc.Description = "Cat with Right Eye";

            //Create the Face
            SvgCircle face = new SvgCircle(70, 95, 50);

            //Set the face styles
            face.Styles.AddStyle("stroke", "black");
            face.Styles.AddStyle("fill", "none");

            //Add the face
            svgDoc.AddChild(face);

            //Create the Right Eye
            SvgCircle rightEye = new SvgCircle(85, 80, 5);

            //Set the right eye style
            rightEye.Styles.AddStyle("stroke", "black");
            rightEye.Styles.AddStyle("fill", "#339933");

            //Add the right eye
            svgDoc.AddChild(rightEye);

            //Save the SVG document to file
            svgDoc.Render(HttpContext.Current.Server.MapPath(filePath));

            //Return the path to the created file
            return filePath;
        }

        #endregion

        #region "Example 4

        /// <summary>
        /// Creates Example 1.4
        /// </summary>
        /// <returns>Example 1.4</returns>
        public IExample Example_1_4()
        {
            Example example = new Example();

            //Create the example details
            example.Ref = "example-4"; ;
            example.Title = "Chapter 1 - Example: 4";
            example.Description = "This is Example 4";
            example.HelpText = "Cat Face With Eyes And One Pair Of Whiskers";

            //Set the method to create the dvg file
            example.CreateFileDelegate = Create_Example_1_4_SVG;

            //Return the example details
            return example;
        }

        /// <summary>
        /// Creates the SVG file for Example 1.4
        /// </summary>
        /// <returns>The path to the created SVG file</returns>
        public string Create_Example_1_4_SVG()
        {
            //Set the path to save the file to
            string filePath = @"~/Files/chpt_01_ex_04.svg";

            //Create the SVG Document
            SVGDocument svgDoc = new SVGDocument();

            //Set details 
            svgDoc.Title = "Cat";
            svgDoc.Description = "Cat with Eyes and Whiskers";

            //Create the Face
            SvgCircle face = new SvgCircle(70, 95, 50);

            //Set the face styles
            face.Styles.AddStyle("stroke", "black");
            face.Styles.AddStyle("fill", "none");

            //Add the face
            svgDoc.AddChild(face);

            //Create the Left eye
            SvgCircle leftEye = new SvgCircle(55, 80, 5);

            //Set the left eye style
            leftEye.Styles.AddStyle("stroke", "black");
            leftEye.Styles.AddStyle("fill", "#339933");

            //Add the left eye
            svgDoc.AddChild(leftEye);

            //Create the Right Eye
            SvgCircle rightEye = new SvgCircle(85, 80, 5);

            //Set the right eye style
            rightEye.Styles.AddStyle("stroke", "black");
            rightEye.Styles.AddStyle("fill", "#339933");

            //Add the right eye
            svgDoc.AddChild(rightEye);

            //Add a group element 
            SvgGroup whiskersGroup = new SvgGroup("whiskers");
            svgDoc.AddChild(whiskersGroup);

            //Whiskers 
            SvgLine line1 = new SvgLine(75, 95, 135, 85);
            SvgLine line2 = new SvgLine(75, 95, 135, 105);

            //Set the whiskers style
            line1.Styles.AddStyle("stroke", "black");
            line2.Styles.AddStyle("stroke", "black");

            //Add the whiskers
            whiskersGroup.AddChild(line1);
            whiskersGroup.AddChild(line2);

            //Save the SVG document to file
            svgDoc.Render(HttpContext.Current.Server.MapPath(filePath));

            //Return the path to the created file
            return filePath;
        }

        #endregion

        #region "Example 5"

        /// <summary>
        /// Creates Example 1.5
        /// </summary>
        /// <returns>Example 1.5</returns>
        public IExample Example_1_5()
        {
            Example example = new Example();

            //Create the example details
            example.Ref = "example-5"; ;
            example.Title = "Chapter 1 - Example: 5";
            example.Description = "This is Example 5";
            example.HelpText = "Cat Face With Eyes And Two Pairs Of Whiskers";

            //Set the method to create the SVG file
            example.CreateFileDelegate = Create_Example_1_5_SVG;

            //Return the example details
            return example;
        }

        /// <summary>
        /// Creates the SVG file for Example 1.5
        /// </summary>
        /// <returns>The path to the created SVG file</returns>
        public string Create_Example_1_5_SVG()
        {
            //Set the path to save the SVG file to 
            string filePath = @"~/Files/chpt_01_ex_05.svg";

            //Create the SVG Document
            SVGDocument svgDoc = new SVGDocument();

            //Set details 
            svgDoc.Title = "Cat";
            svgDoc.Description = "Stick Figure of a Cat";

            //Create the Face
            SvgCircle face = new SvgCircle(70, 95, 50);

            //Set the face styles
            face.Styles.AddStyle("stroke", "black");
            face.Styles.AddStyle("fill", "none");

            //Add the face
            svgDoc.AddChild(face);

            //Create the Left eye
            SvgCircle leftEye = new SvgCircle(55, 80, 5);

            //Set the left eye style
            leftEye.Styles.AddStyle("stroke", "black");
            leftEye.Styles.AddStyle("fill", "#339933");

            //Add the left eye
            svgDoc.AddChild(leftEye);

            //Create the Right Eye
            SvgCircle rightEye = new SvgCircle(85, 80, 5);

            //Set the right eye style
            rightEye.Styles.AddStyle("stroke", "black");
            rightEye.Styles.AddStyle("fill", "#339933");

            //Add the right eye
            svgDoc.AddChild(rightEye);

            //Add a group element 
            SvgGroup whiskersGroup = new SvgGroup("whiskers");
            svgDoc.AddChild(whiskersGroup);

            //Create Whiskers 
            SvgLine line1 = new SvgLine(75, 95, 135, 85);
            SvgLine line2 = new SvgLine(75, 95, 135, 105);

            //Set the whiskers style
            line1.Styles.AddStyle("stroke", "black");
            line2.Styles.AddStyle("stroke", "black");

            //Add the whiskers
            whiskersGroup.AddChild(line1);
            whiskersGroup.AddChild(line2);

            //We need a 'Use' section to duplicate the whiskers
            SvgUse useSection = new SvgUse();
            useSection.SetAssociatedId("whiskers");
            Transform trans = new Transform();
            trans.AddTransform(new Scaling(-1, 1));
            trans.AddTransform(new Translation(-140, 0));
            useSection.AddTransform(trans);

            //Add the second pair of whiskers
            svgDoc.AddChild(useSection);

            //Save the SVG document to file
            svgDoc.Render(HttpContext.Current.Server.MapPath(filePath));

            //Return the path to the created file
            return filePath;
        }

        #endregion

        #region "Example 6"

        /// <summary>
        /// Creates Example 1.6
        /// </summary>
        /// <returns>Example 1.6</returns>
        public IExample Example_1_6()
        {
            Example example = new Example();

            //Set the example details
            example.Ref = "example-6"; ;
            example.Title = "Chapter 1 - Example: 6";
            example.Description = "This is Example 6";
            example.HelpText = "Cat Face With Ears and Mouth";

            //Set the function to create the file
            example.CreateFileDelegate = Create_Example_1_6_SVG;

            //Return the example details
            return example;
        }

        /// <summary>
        /// Creates the SVG file for Example 1.6
        /// </summary>
        /// <returns>The path to the created SVG file</returns>
        public string Create_Example_1_6_SVG()
        {
            //Set the path to save the file to
            string filePath = @"~/Files/chpt_01_ex_06.svg";

            //Create the SVG Document
            SVGDocument svgDoc = new SVGDocument();

            //Set details 
            svgDoc.Title = "Cat";
            svgDoc.Description = "Cat With Ears";

            //Create the Face
            SvgCircle face = new SvgCircle(70, 95, 50);

            //Set the face styles
            face.Styles.AddStyle("stroke", "black");
            face.Styles.AddStyle("fill", "none");

            //Add the face
            svgDoc.AddChild(face);

            //Create the Left Eye
            SvgCircle leftEye = new SvgCircle(55, 80, 5);

            //Set the left eye style
            leftEye.Styles.AddStyle("stroke", "black");
            leftEye.Styles.AddStyle("fill", "#339933");

            //Add the left eye
            svgDoc.AddChild(leftEye);

            //Create the Right Eye
            SvgCircle rightEye = new SvgCircle(85, 80, 5);

            //Set the right eye style
            rightEye.Styles.AddStyle("stroke", "black");
            rightEye.Styles.AddStyle("fill", "#339933");

            //Add the right eye
            svgDoc.AddChild(rightEye);

            //Add a group element 
            SvgGroup whiskersGroup = new SvgGroup("whiskers");
            svgDoc.AddChild(whiskersGroup);

            //Create Whiskers 
            SvgLine line1 = new SvgLine(75, 95, 135, 85);
            SvgLine line2 = new SvgLine(75, 95, 135, 105);

            //Set the whiskers style
            line1.Styles.AddStyle("stroke", "black");
            line2.Styles.AddStyle("stroke", "black");

            //Add the whiskers
            whiskersGroup.AddChild(line1);
            whiskersGroup.AddChild(line2);

            //We need a 'Use' section to duplicate the whiskers
            SvgUse useSection = new SvgUse();
            useSection.SetAssociatedId("whiskers");
            Transform trans = new Transform();
            trans.AddTransform(new Scaling(-1, 1));
            trans.AddTransform(new Translation(-140, 0));
            useSection.AddTransform(trans);

            //Add the second whiskers
            svgDoc.AddChild(useSection);

            //Add Ears
            SvgPolyLine ears = new SvgPolyLine();
            ears.AddPoint(108, 62);
            ears.AddPoint(90, 10);
            ears.AddPoint(70, 45);
            ears.AddPoint(50, 10);
            ears.AddPoint(32, 62);

            //Set the ears style
            ears.Styles.AddStyle("stroke", "black");
            ears.Styles.AddStyle("fill", "none");

            //Add the ears
            svgDoc.AddChild(ears);

            //Add a Mouth
            SvgPolyLine mouth = new SvgPolyLine();
            mouth.AddPoint(35, 110);
            mouth.AddPoint(45, 120);
            mouth.AddPoint(95, 120);
            mouth.AddPoint(105, 110);

            //Set the mouth style
            mouth.Styles.AddStyle("stroke", "black");
            mouth.Styles.AddStyle("fill", "none");

            //Add the mouth
            svgDoc.AddChild(mouth);

            //Save the SVG document to file
            svgDoc.Render(HttpContext.Current.Server.MapPath(filePath));

            //Return the path to the created file
            return filePath;
        }

        #endregion

        #region "Example 7"

        /// <summary>
        /// Creates Example 1.7
        /// </summary>
        /// <returns>Example 1.7</returns>
        public IExample Example_1_7()
        {
            Example example = new Example();

            //Set the example details
            example.Ref = "example-7"; ;
            example.Title = "Chapter 1 - Example: 7";
            example.Description = "This is Example 7";
            example.HelpText = "Cat Face With Nose";

            //Set the function to create the svg file
            example.CreateFileDelegate = Create_Example_1_7_SVG;

            //Return the example details
            return example;
        }

        /// <summary>
        /// Creates the SVG file for Example 1.7
        /// </summary>
        /// <returns>The path to the created SVG file</returns>
        public string Create_Example_1_7_SVG()
        {
            //Set the path to save the file
            string filePath = @"~/Files/chpt_01_ex_07.svg";

            //Create the SVG Document
            SVGDocument svgDoc = new SVGDocument();

            //Set details 
            svgDoc.Title = "Cat";
            svgDoc.Description = "Stick Figure of a Cat";

            //Create the Face
            SvgCircle face = new SvgCircle(70, 95, 50);

            //Set the face styles
            face.Styles.AddStyle("stroke", "black");
            face.Styles.AddStyle("fill", "none");

            //Add the face
            svgDoc.AddChild(face);

            //Create the Left Eye
            SvgCircle leftEye = new SvgCircle(55, 80, 5);

            //Set the left eye style
            leftEye.Styles.AddStyle("stroke", "black");
            leftEye.Styles.AddStyle("fill", "#339933");

            //Add the left eye
            svgDoc.AddChild(leftEye);

            //Crate the Right Eye
            SvgCircle rightEye = new SvgCircle(85, 80, 5);

            //Set the right eye style
            rightEye.Styles.AddStyle("stroke", "black");
            rightEye.Styles.AddStyle("fill", "#339933");

            //Add the right eye
            svgDoc.AddChild(rightEye);

            //Add a group element 
            SvgGroup whiskersGroup = new SvgGroup("whiskers");
            svgDoc.AddChild(whiskersGroup);

            //Whiskers 
            SvgLine line1 = new SvgLine(75, 95, 135, 85);
            SvgLine line2 = new SvgLine(75, 95, 135, 105);

            //Set the whiskers style
            line1.Styles.AddStyle("stroke", "black");
            line2.Styles.AddStyle("stroke", "black");

            //Add the whiskers
            whiskersGroup.AddChild(line1);
            whiskersGroup.AddChild(line2);

            //We need a 'Use' section to duplicate the whiskers
            SvgUse useSection = new SvgUse();
            useSection.SetAssociatedId("whiskers");
            Transform trans = new Transform();
            trans.AddTransform(new Scaling(-1, 1));
            trans.AddTransform(new Translation(-140, 0));
            useSection.AddTransform(trans);

            //Add the other pair of shiskers
            svgDoc.AddChild(useSection);

            //Create Ears
            SvgPolyLine ears = new SvgPolyLine();
            ears.AddPoint(108, 62);
            ears.AddPoint(90, 10);
            ears.AddPoint(70, 45);
            ears.AddPoint(50, 10);
            ears.AddPoint(32, 62);

            //Set the ears style
            ears.Styles.AddStyle("stroke", "black");
            ears.Styles.AddStyle("fill", "none");

            //Add the ears
            svgDoc.AddChild(ears);

            //Add a Mouth
            SvgPolyLine mouth = new SvgPolyLine();
            mouth.AddPoint(35, 110);
            mouth.AddPoint(45, 120);
            mouth.AddPoint(95, 120);
            mouth.AddPoint(105, 110);

            //Set the mouth style
            mouth.Styles.AddStyle("stroke", "black");
            mouth.Styles.AddStyle("fill", "none");

            //Add the mouth
            svgDoc.AddChild(mouth);

            //Nose
            SvgPath nose = new SvgPath();
            nose.AddDirective(new SvgPathMoveTo(75, 90, true));
            nose.AddDirective(new SvgPathLineTo(65, 90, true));
            nose.AddDirective(new SvgPathArc(5, 10, 0, false, false, 75, 90, true));

            //Set the nose style
            nose.Styles.AddStyle("stroke", "black");
            nose.Styles.AddStyle("fill", "#ffcccc");

            //Add the nose
            svgDoc.AddChild(nose);

            //Save the SVG document to file
            svgDoc.Render(HttpContext.Current.Server.MapPath(filePath));

            //Return the path to the created file
            return filePath;
        }

        #endregion

        #region "Example 8"

        /// <summary>
        /// Creates Example 1.8
        /// </summary>
        /// <returns>Example 1.8</returns>
        public IExample Example_1_8()
        {
            Example example = new Example();

            //Set the example details
            example.Ref = "example-8"; ;
            example.Title = "Chapter 1 - Example: 8";
            example.Description = "This is Example 8";
            example.HelpText = "Cat Face With Text Label";
            
            //Set the function to create the file
            example.CreateFileDelegate = Create_Example_1_8_SVG;

            //Return the example details
            return example;
        }

        /// <summary>
        /// Creates the SVG file for Example 1.8
        /// </summary>
        /// <returns>The path to the created SVG file</returns>
        public string Create_Example_1_8_SVG()
        {
            //Set the path to save the svg file to
            string filePath = @"~/Files/chpt_01_ex_08.svg";

            //Create the SVG Document
            SVGDocument svgDoc = new SVGDocument();

            //Set details 
            svgDoc.Title = "Cat";
            svgDoc.Description = "Stick Figure of a Cat";

            //Create the Face
            SvgCircle face = new SvgCircle(70, 95, 50);

            //Set the face styles
            face.Styles.AddStyle("stroke", "black");
            face.Styles.AddStyle("fill", "none");

            //Add the face
            svgDoc.AddChild(face);

            //Create the Left eye
            SvgCircle leftEye = new SvgCircle(55, 80, 5);

            //Set the left eye style
            leftEye.Styles.AddStyle("stroke", "black");
            leftEye.Styles.AddStyle("fill", "#339933");

            //Add the left eye
            svgDoc.AddChild(leftEye);

            //Create the Right Eye
            SvgCircle rightEye = new SvgCircle(85, 80, 5);

            //Set the right eye style
            rightEye.Styles.AddStyle("stroke", "black");
            rightEye.Styles.AddStyle("fill", "#339933");

            //Add the right eye
            svgDoc.AddChild(rightEye);

            //Add a group element 
            SvgGroup whiskersGroup = new SvgGroup("whiskers");
            svgDoc.AddChild(whiskersGroup);

            //Whiskers 
            SvgLine line1 = new SvgLine(75, 95, 135, 85);
            SvgLine line2 = new SvgLine(75, 95, 135, 105);

            //Set the whiskers style
            line1.Styles.AddStyle("stroke", "black");
            line2.Styles.AddStyle("stroke", "black");

            //Add the whiskers
            whiskersGroup.AddChild(line1);
            whiskersGroup.AddChild(line2);

            //We need a 'Use' section to duplicate the whiskers
            SvgUse useSection = new SvgUse();
            useSection.SetAssociatedId("whiskers");
            Transform trans = new Transform();
            trans.AddTransform(new Scaling(-1, 1));
            trans.AddTransform(new Translation(-140, 0));
            useSection.AddTransform(trans);

            //Add the second pair of whiskers
            svgDoc.AddChild(useSection);

            //Create Ears
            SvgPolyLine ears = new SvgPolyLine();
            ears.AddPoint(108, 62);
            ears.AddPoint(90, 10);
            ears.AddPoint(70, 45);
            ears.AddPoint(50, 10);
            ears.AddPoint(32, 62);

            //Set the ears style
            ears.Styles.AddStyle("stroke", "black");
            ears.Styles.AddStyle("fill", "none");

            //Add the ears
            svgDoc.AddChild(ears);

            //Add a Mouth
            SvgPolyLine mouth = new SvgPolyLine();
            mouth.AddPoint(35, 110);
            mouth.AddPoint(45, 120);
            mouth.AddPoint(95, 120);
            mouth.AddPoint(105, 110);

            //Set the mouth style
            mouth.Styles.AddStyle("stroke", "black");
            mouth.Styles.AddStyle("fill", "none");

            //Add the mouth
            svgDoc.AddChild(mouth);

            //Create the Nose
            SvgPath nose = new SvgPath();
            nose.AddDirective(new SvgPathMoveTo(75, 90, true));
            nose.AddDirective(new SvgPathLineTo(65, 90, true));
            nose.AddDirective(new SvgPathArc(5, 10, 0, false, false, 75, 90, true));

            //Set the nose style
            nose.Styles.AddStyle("stroke", "black");
            nose.Styles.AddStyle("fill", "#ffcccc");

            //Add the nose
            svgDoc.AddChild(nose);

            //Text label
            SvgText label = new SvgText(60, 165, "Cat");

            //Set the label styles
            label.Styles.AddStyle("font-family", "sans-serif");
            label.Styles.AddStyle("font-size", "14pt");
            label.Styles.AddStyle("stroke", "none");
            label.Styles.AddStyle("fill", "black");

            //Add the text label
            svgDoc.AddChild(label);

            //Save the SVG document to file
            svgDoc.Render(HttpContext.Current.Server.MapPath(filePath));

            //Return the path to the created file
            return filePath;
        }

        #endregion

        #endregion 

    }
}