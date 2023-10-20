using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_CNTT_DHTNMT.Models;

namespace Web_CNTT_DHTNMT.Controllers
{
    public class SearchController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        // GET: Search
        /*Search Tin Tức*/
        [HttpPost]
        public ActionResult Index(String searchString)
        {

            Web_CNTT_DHTNMTDataContext db = new Web_CNTT_DHTNMTDataContext();
            List<@new> news;
            if (string.IsNullOrEmpty(searchString))
            {
                news = db.news.ToList();
            }
            else
            {
                news = db.news.Where(x => (x.title.Contains(searchString))).ToList();
            }

            return View(news);
        }

        public JsonResult GetTinTuc(String term)
        {
            Web_CNTT_DHTNMTDataContext db = new Web_CNTT_DHTNMTDataContext();
            List<string> news;
            List<user> dsUser = db.users.ToList();
            List<news_group> dsNews_Group = db.news_groups.ToList();
            ViewData["User"] = dsUser;
            ViewData["NhomTinTuc"] = dsNews_Group;
            news = db.news.Where(x => (x.title.StartsWith(term)))
                .Select(y => y.title).ToList();

            return Json(news, JsonRequestBehavior.AllowGet);
        }
    }
}