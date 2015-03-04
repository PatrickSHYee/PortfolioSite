using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.tl_About = "About Patrick Yee";
            ViewBag.tl_Portfolio = "About the Portfolio";
            ViewBag.txt_Portfolio = "Patrick Yee's portfolio site is a collection of the projects or soon to be projects that he done at Seed Paths, Westwood College of Technology, and his personal life.  At Seed Paths, Patrick developed and continued learning about being a C# .NET developer.  He learned many new features about C# and .NET that he did not learned from Colorado State University.  Patrick has entail his development work from projects from Westwood to present time at Seed Paths.  The Westwood projects are a team of developers working for the same goals.  These teams range from 5 to 15 developers.  At Westwood, most of the instructors felt that Patrick was a great asset as a leader and very knowledgeable software engineer.  Also, the past 8 of years, Patrick has design numerous of games that he never developed, but wants to develop in the future.";
            ViewBag.tl_PatStory = "Patrick's Story";
            ViewBag.txt_PatStoryP1 = "Patrick is intrigued for technology since his mother bought his first game console to his first build to the current build.  The individual components that make up computers this is makes Patrick love about technology.  How each component has a certain detailed task that they do in a computer; depending how fast or architecture or features of each component.  Just like a family or a team, where each member helps or provides knowledge or data for the whole unit.  Patrick loves his family, where they are a big influence in his life and how he sets his goals to live up to.  Remembering one Christmas, his cousin Lisa told his about his love for gaming and there was a profession to be video game tester.  Where he can play games all day long.  It never occur or relate to Patrick that software engineering could develop and evolve technology.  It builds on top each other.";
            ViewBag.txt_PatStoryP2 = "Before high school, Patrick was told that wasn't going to graduate high school on time.  He pushed himself and graduated a semester early.  In high school Patrick started to learn more about certain technologies through video editing to photo editing and animations.  Also, Patrick attended a local community college to learn about computing computers and various computer science related courses.  He knows Java, C, and Unix from this experience.  Patrick transferred to Colorado State University, where he took a couple of computer science courses – discrete mathematics, data structures and algorithms, and computer systems.  He also took some web development courses, where he learned about ColdFusion and ASP.NET.  Patrick joined Triangle Fraternity and was giving a role at the chapter as an IT personal.  He related the web development courses to developing the Triangle website that was in PHP.  Patrick love learning about the logic at Colorado State University, but it was not hands on like it was at the community college.  Patrick transferred to Westwood College of College and received a bachelor's of science degree in game software development.  Patrick learned about programming various game engines, cross-platforming, and writing design and technical documents.  While attending Westwood, Patrick work as busser at a restaurant and was his fallback plan, if he was not hired in the software engineering industry.";
            ViewBag.txt_PatStoryP3 = "Patrick received an opportunity to work at a start-up company, Digital Access, to develop a real estate web application.  Upon developing this application, Patrick had to learned how a real estate agent worked.  There various tools and software that they currently used and how they organized there appointments, tasks, calenders, contracts, and holiday events.  Patrick graduated from Westwood College and was still working at a restaurant where he devoted additional 8 years.  But, he moved from being a busser to server and until his final position at the restaurant as a cook.  After a long work day at the restaurant, Patrick was sitting and was about to eat this small pizza.  His body was so worn out and stressed that he could not eat.  The next day he decided to quit and he remembering interviewing with Patrick McClary from Seed Paths about a great opportunity.  Patrick contact Patrick McClary about  now he wants to attend Seed Paths to become an C# developer.  McClary tells Patrick he has a week to go to the Denver Workforce Center to get a grant to fund the program and reapply to the program.  Even though Patrick became sick, he was driven to get everything done.  Now, Patrick has an updated education and feels more confident  about being a software engineer.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}