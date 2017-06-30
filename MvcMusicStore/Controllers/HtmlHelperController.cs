using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class HtmlHelperController : Controller
    {
        private MusicStoreDB db = new MusicStoreDB();
        // GET: HtmlHelper
        public ActionResult Index()
        {

            Album album = db.Albums.Where(u => u.AlbumId==1).FirstOrDefault();
            ViewBag.Genres = new SelectList(db.Genres.OrderBy(g => g.Name), "GenreId", "Name", album.GenreId);

            return View(album);
        }

        public ActionResult HandleSubmit()
        {
            int i = Request.Form.Count;
           string color =  Request["color"];
            return View();
        }
    }
}