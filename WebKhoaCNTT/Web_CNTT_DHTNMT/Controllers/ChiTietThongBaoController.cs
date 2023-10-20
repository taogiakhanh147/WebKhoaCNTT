using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_CNTT_DHTNMT.Models;

namespace Web_CNTT_DHTNMT.Controllers
{
    public class ChiTietThongBaoController : Controller
    {
        // GET: ChiTietThongBao
        public ActionResult Index(string id)
        {
            if (id == null)
            {
                return Redirect("/");
            }
            Web_CNTT_DHTNMTDataContext context = new Web_CNTT_DHTNMTDataContext();
            @new p = context.news.FirstOrDefault(x => x.slug == id);
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

            /* Get id of news */
            @new n = context.news.FirstOrDefault(x => x.slug == id);
            var news_id = n.id;

            List<comment> dsBinhLuan = context.comments
                                                .Where(x => x.news_id == news_id)
                                                .OrderByDescending(x => x.date)
                                                .ToList();
            ViewData["BinhLuan"] = dsBinhLuan;


            List<user> dsUser = context.users.ToList();
            ViewData["User"] = dsUser;
            ViewData["TinNoiBat"] = TinNoiBat;
            ViewData["TinTucTruong"] = TinTucTruong;
            return View(p);
        }
    }
}