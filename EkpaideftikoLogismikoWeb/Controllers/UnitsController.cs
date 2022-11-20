using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace EkpaideftikoLogismikoWeb.Controllers
{
    public class UnitsController : Controller
    {
        // GET: Units
        public ActionResult Units()
        {
            string[] units = Directory.GetFiles(HostingEnvironment.MapPath("~/Content/Data/unitdata"), "unit*.txt");
            string[] titles = new string[units.Length];
            StreamReader sr = null;
            for(int i = 0; i < titles.Length; i++)
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

        public ActionResult Unit(string unit)
        {
            StreamReader sr = new StreamReader(HostingEnvironment.MapPath("~/Content/Data/unitdata/" + unit + ".txt"), Encoding.Default);
            ViewBag.unitTitle = sr.ReadLine();
            List<string> people = new List<string>();
            while(!sr.EndOfStream)
            {
                string temp = sr.ReadLine();
                people.Add(temp);
            }
            sr.Close();
            ViewBag.unit = unit;
            ViewBag.people = people;
            ViewBag.num = unit[unit.Length - 1];
            return View();
        }

        public ActionResult Info(string person)
        {
            StreamReader sr = new StreamReader(HostingEnvironment.MapPath("~/Content/Data/peopledata/peopleinfo/" + person + ".txt"), Encoding.Default);
            string Name = sr.ReadLine();
            string Birthdate = sr.ReadLine();
            string Birthplace = sr.ReadLine();
            string Deathdate = sr.ReadLine();
            string Deathplace = sr.ReadLine();
            sr = new StreamReader(HostingEnvironment.MapPath("~/Content/Data/peopledata/peopledesc/" + person + ".html"), Encoding.Default);
            string Desc = sr.ReadToEnd();
            return Json(new { name = Name, birthdate = Birthdate, birthplace = Birthplace, deathdate = Deathdate, deathplace = Deathplace, desc = Desc });
        }
    }
}