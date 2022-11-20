using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using EkpaideftikoLogismikoWeb.Models;

namespace EkpaideftikoLogismikoWeb.Controllers
{
    public class QuizesController : Controller
    {
        // GET: Quizes
        public ActionResult Quizes()
        {
            string[] units = Directory.GetFiles(HostingEnvironment.MapPath("~/Content/Data/unitdata"), "unit*.txt");
            string[] titles = new string[units.Length];
            StreamReader sr = null;
            for (int i = 0; i < titles.Length; i++)
            {
                sr = new StreamReader(units[i], Encoding.Default);
                titles[i] = sr.ReadLine();
                sr.Close();
            }

            units = units.Select(Path.GetFileName).ToArray();
            for (int i = 0; i < units.Length; i++)
            {
                units[i] = units[i].Split('.')[0];
            }
            ViewBag.units = units;
            ViewBag.titles = titles;
            return View();
        }

        public ActionResult Quiz(string unit)
        {
            List<Question> questions = new List<Question>();
            List<Answer> answers = null;
            StreamReader sr;
            if (unit != "revision")
            {
                sr = new StreamReader(HostingEnvironment.MapPath("~/Content/Data/unitdata/" + unit + ".txt"), Encoding.Default);
                ViewBag.unitTitle = sr.ReadLine();
            }
            else
            {
                ViewBag.unitTitle = "Επανάληψη";
            }
            sr = new StreamReader(HostingEnvironment.MapPath("~/Content/Data/quizes/" + unit + ".txt"), Encoding.Default);
            ViewBag.totalQuestions = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                var text = sr.ReadLine();
                answers = new List<Answer>();
                for(int i = 0; i < 4; i++)
                {
                    var answer = sr.ReadLine().Split('|');
                    answers.Add(new Answer(answer[0], bool.Parse(answer[1])));
                }
                questions.Add(new Question(text, answers));
            }
            sr.Close();
            ViewBag.unit = unit;
            ViewBag.questions = questions;
            ViewBag.num = unit[unit.Length - 1];
            return View();
        }
    }
}