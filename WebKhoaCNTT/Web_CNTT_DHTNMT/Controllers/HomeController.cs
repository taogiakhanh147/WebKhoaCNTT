using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_CNTT_DHTNMT.Models;

namespace Web_CNTT_DHTNMT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id, string SearchString)
        {
            /*string slug = Request.QueryString["slug"];*/

            /*if (id == null)
            {
                return Redirect("/");
            }*/

            Web_CNTT_DHTNMTDataContext context = new Web_CNTT_DHTNMTDataContext();
            @new p = context.news.FirstOrDefault(x => x.slug == id);

            /*Tin thông báo*/
            List<@new> TinThongBao = context.news.Take(30)
                                            .Where(x => x.newsgroup_id == 1 && x.status == true)
                                            .OrderByDescending(x => x.created_at)
                                            .ToList();
            /*Tin nổi bật*/
            List<@new> TinNoiBat = context.news.Take(30)
                                            .Where(x => x.newsgroup_id == 2 && x.status == true)
                                            .OrderByDescending(x => x.created_at)
                                            .ToList();
            /*Tin tức trường*/
            List<@new> TinTucTruong = context.news.Take(30)
                                            .Where(x => x.newsgroup_id == 3 && x.status == true)
                                            .OrderByDescending(x => x.created_at)
                                            .ToList();
            ViewData["TinThongBao"] = TinThongBao;
            ViewData["TinNoiBat"] = TinNoiBat;
            ViewData["TinTucTruong"] = TinTucTruong;
            return View(p);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}