using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBTecsup.Models;

namespace WEBTecsup.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            
            if (Session["Movies"]==null)
            {
                List<Movie> movies = new List<Movie>();
                movies.Add(new Movie { ID = 1, Gender = "Drama", Price = 100, Titlle = "Venon", ReleaseDate = DateTime.Today });
                movies.Add(new Movie { ID = 2, Gender = "Drama", Price = 150, Titlle = "Venon 2", ReleaseDate = DateTime.Today });
                Session["Movies"] = movies;
            }
            


            return View(Session["Movies"]);
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {

            var model = ((List<Movie>)Session["Movies"]).Where(x => x.ID == id).FirstOrDefault();

            return View(model);
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        public ActionResult Create(Movie model)
        {
            try
            {
                if (Session["Movies"]==null)                
                    Session["Movies"] = new List<Movie>();                
                // TODO: Add insert logic here
                ((List<Movie>)Session["Movies"]).Add(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            var model = ((List<Movie>)Session["Movies"]).Where(x => x.ID == id).FirstOrDefault();

            return View(model);
        }

        // POST: Movie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int id)
        {
            var model = ((List<Movie>)Session["Movies"]).Where(x => x.ID == id).FirstOrDefault();

            return View(model);
        }

        // POST: Movie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Movie model)
        {
            try
            {
                // TODO: Add delete logic here
                //((List<Movie>)Session["Movies"]).Remove(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
