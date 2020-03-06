using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ppedv.Finex.Logic;
using ppedv.Finex.Model;

namespace ppedv.Finex.UI.Web.Controllers
{
    public class MediController : Controller
    {
        Core core = new Core();

        // GET: Medi
        public ActionResult Index()
        {
            return View(core.Repository.Query<Medikament>().ToList());
        }

        // GET: Medi/Details/5
        public ActionResult Details(int id)
        {
            return View(core.Repository.GetById<Medikament>(id));
        }

        // GET: Medi/Create
        public ActionResult Create()
        {
            return View(new Medikament() { Name = "NEU", Packungsgröße = 17 });
        }

        // POST: Medi/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Medikament medi)
        {
            try
            {
                core.Repository.Add(medi);
                core.Repository.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Medi/Edit/5
        public ActionResult Edit(int id)
        {
            return View(core.Repository.GetById<Medikament>(id));
        }

        // POST: Medi/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Medikament medi)
        {
            try
            {
                core.Repository.Update(medi);
                core.Repository.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Medi/Delete/5
        public ActionResult Delete(int id)
        {
            return View(core.Repository.GetById<Medikament>(id));
        }

        // POST: Medi/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Medikament medi)
        {
            try
            {
                var loaded = core.Repository.GetById<Medikament>(id);
                if (loaded != null)
                {
                    core.Repository.Delete(loaded);
                    core.Repository.SaveChanges();
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}