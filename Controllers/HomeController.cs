using SVGEssentials.Chapters;
using SVGEssentials.Models;
using SVGEssentials.Models.Examples;
using System.Web.Mvc;

namespace SVGEssentials.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Book book = new Book();
                        
            return View(book);
        }

        public ActionResult Chapter(string chapterTitle)
        {
            //Get a handle on the book details
            Book book = new Book();

            //Get a handle on the specified Chapter
            IChapter chapter = book.GetChapter(chapterTitle);

            //Display the chapter details
            return View(chapter);
        }


        public ActionResult Example(string chapterTitle, string exampleId)
        {
            //Get a handle on the book details
            Book book = new Book();

            //Get a handle on the specified example
            IExample example = book.GetExample(chapterTitle, exampleId);

            //Display the example
            return View(example);
        }

    }
}