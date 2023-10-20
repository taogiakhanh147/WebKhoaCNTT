using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_CNTT_DHTNMT.Models;

namespace Web_CNTT_DHTNMT.Controllers
{
    public class TrangCon1Controller : Controller
    {
        // GET: TrangCon1
        public ActionResult GioiThieu(string id)
        {
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
            ViewData["TinNoiBat"] = TinNoiBat;
            ViewData["TinTucTruong"] = TinTucTruong;
            return View(p);
        }

        public ActionResult GioiThieu1(string id)
        {
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
            ViewData["TinNoiBat"] = TinNoiBat;
            ViewData["TinTucTruong"] = TinTucTruong;
            return View(p);
        }

        public ActionResult CoCauToChuc(string id)
        {
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
            ViewData["TinNoiBat"] = TinNoiBat;
            ViewData["TinTucTruong"] = TinTucTruong;
            return View(p);
        }
    }
}