using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_CNTT_DHTNMT.Models;
using Slugify;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Web_CNTT_DHTNMT.Controllers
{
    [Authorize(Roles = "Quản trị viên, Giảng viên")]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index(string id)
        {
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

        /*Tạo giao diện tin tức admin*/
        public ActionResult QuanLyTinTuc()
        {
            Web_CNTT_DHTNMTDataContext context = new Web_CNTT_DHTNMTDataContext();

            List<@new> dsNews = context.news.OrderByDescending(x => x.created_at).ToList();

            List<user> dsUser = context.users.ToList();
            List<news_group> dsNews_Group = context.news_groups.ToList();
            ViewData["User"] = dsUser;
            ViewData["NhomTinTuc"] = dsNews_Group;

            return View(dsNews);
        }

        /*Tạo chức năng thêm mới*/
        public ActionResult Create()
        {
            Web_CNTT_DHTNMTDataContext context = new Web_CNTT_DHTNMTDataContext();

            if (Request.Form.Count > 0)
            {
                var usergroup = Session["UserGroupSession"].ToString();

                SlugHelper helper = new SlugHelper();
                @new news = new @new();

                news.title = Request.Form["title"];
                news.slug = helper.GenerateSlug(Request.Form["title"]);
                news.content = Request.Unvalidated.Form["content"];
                news.created_at = DateTime.Parse(Request.Form["created_at"]);
                news.newsgroup_id = int.Parse(Request.Form["newsgroup_id"]);
                news.user_id = int.Parse(Session["UserIdSession"].ToString());

                /*Phân quyền để ẩn hiện thanh trạng thái*/
                if (usergroup == "1")        // Quản trị
                {
                    news.status = bool.Parse(Request.Form["status"]);
                }
                else if (usergroup == "2")   // Nhân viên
                {
                    news.status = false;  
                }

                /*Hình ảnh*/
                /*HttpPostedFileBase file = Request.Files["imageNews"];
                if (file != null && file.FileName != "")
                {
                    string serverPath = HttpContext.Server.MapPath("~/images/tintuc");
                    string filePath = serverPath + "/" + file.FileName;
                    file.SaveAs(filePath);
                    news.imageNews = file.FileName;
                }
                else
                {
                    news.imageNews = "default-image.png";
                }*/

                context.news.InsertOnSubmit(news);
                context.SubmitChanges();
                return RedirectToAction("QuanLyTinTuc");
            }


            List<news_group> dsTinTuc = context.news_groups.ToList();
            ViewData["NhomTintuc"] = dsTinTuc;

            return View();
        }

        /*Tạo chức năng chỉnh sửa*/
        public ActionResult Edit(int id)
        {
            var usergroup = Session["UserGroupSession"].ToString();

            SlugHelper helper = new SlugHelper();
            Web_CNTT_DHTNMTDataContext context = new Web_CNTT_DHTNMTDataContext();
            @new news = context.news.FirstOrDefault(x => x.id == id);

            if (Request.Form.Count == 0)
            {
                List<news_group> dsTinTuc = context.news_groups.ToList();
                ViewData["NhomTintuc"] = dsTinTuc;

                return View(news);
            }

            news.title = Request.Form["title"];
            news.slug = helper.GenerateSlug(Request.Form["title"]);
            news.content = Request.Unvalidated.Form["content"];
            /*news.updated_at = DateTime.Now;*/
            news.created_at = DateTime.Parse(Request.Form["created_at"]);
            news.newsgroup_id = int.Parse(Request.Form["newsgroup_id"]);

            /*Phân quyền để hiển thị thanh trạng thái*/
            if (usergroup == "1")        // Quản trị
            {
                news.status = bool.Parse(Request.Form["status"]);
            }
            else if (usergroup == "2")   // Nhân viên
            {
                news.status = false;
            }

            context.SubmitChanges();
            return RedirectToAction("QuanLyTinTuc");
        }

        /*Tạo chức năng xem chi tiết*/
        public ActionResult Details(int id)
        {
            Web_CNTT_DHTNMTDataContext context = new Web_CNTT_DHTNMTDataContext();

            @new p = context.news.FirstOrDefault(x => x.id == id);
            List<news_group> dsNews_Group = context.news_groups.ToList();

            ViewData["NhomTinTuc"] = dsNews_Group;
            return View(p);
        }

        /*Tạo chức năng xóa*/
        [Authorize(Roles = "Quản trị viên")]
        public ActionResult Delete(int id)
        {
            Web_CNTT_DHTNMTDataContext context = new Web_CNTT_DHTNMTDataContext();
            @new p = context.news.FirstOrDefault(x => x.id == id);

            context.news.DeleteOnSubmit(p);
            context.SubmitChanges();

            return RedirectToAction("QuanLyTinTuc");
        }

        /*Search Tin Tức*/
        [HttpPost]
        public ActionResult QuanLyTinTuc(String searchTerm)
        {

            Web_CNTT_DHTNMTDataContext db = new Web_CNTT_DHTNMTDataContext();
            List<@new> news;
            if (string.IsNullOrEmpty(searchTerm))
            {
                news = db.news.ToList();
            }
            else
            {
                news = db.news.Where(x => (x.title.Contains(searchTerm))).ToList();
            }

            return View(news);
        }

        public JsonResult GetTinTucs(String term)
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

        /*Tạo report*/
        public List<@new> GetKhachHangs()
        {
            string cnnString = ConfigurationManager.ConnectionStrings["KhoaCNTT_DHTNMTConnectionString"].ConnectionString;
            SqlConnection cnn = new SqlConnection(cnnString);
            cnn.Open();

            SqlCommand command = new SqlCommand("SELECT title, created_at, status FROM news ", cnn);
            IDataReader reader = command.ExecuteReader(CommandBehavior.Default);

            List<@new> lstData = new List<@new>();

            while (reader.Read())
            {
                lstData.Add(new @new()
                {
                    title = reader["title"].ToString(),
                    created_at = DateTime.Parse(reader["created_at"].ToString()),
                    status = bool.Parse(reader["status"].ToString())
                });
            }

            return lstData;
        }
    }
}