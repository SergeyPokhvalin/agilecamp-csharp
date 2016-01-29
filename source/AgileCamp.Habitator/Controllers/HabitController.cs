using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgileCamp.Habitator.Controllers
{
    public class HabitController : Controller
    {
        // GET: Habit
        public ActionResult AddNewHabit()
        {
            return View();
        }

        //public ActionResult AddNewHabit2_New(int i1, int i2, int i3)
        //{
        //    if (i1 == i2)
        //        if (i2 == i3)
        //    {
        //        return View();
        //    }


        //    return null;
        //}
        //public ActionResult AddNewHabit3_New()
        //{
            
        //    var o2= ()=>{ return new object(); };

        //}

    }
}
