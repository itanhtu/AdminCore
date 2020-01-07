using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Source.Models;
using Source.Models.DBF;

namespace Source.Controllers
{
    public class AdminController : Controller
    {
        private IRepository db;
        private readonly IHostingEnvironment hostingEnvironment;
        public AdminController(IRepository repository, IHostingEnvironment hosting)
        {
            db = repository;
            hostingEnvironment = hosting;
        }
        public ViewResult Index()
        {
            return View();
        }
        public IActionResult LoaiTinTuc()
        {
            var model = db.tbnewscates;
            return View(model);
        }
        [HttpPost]
        public IActionResult NewsCateAdd(Tbnewscate newscate)
        {
            db.SaveNewsCate(newscate);
            return RedirectToAction("LoaiTinTuc");
        }
        public ActionResult NewsCateDelete(int id)
        {
            db.NewsCateDelete(id);
            return RedirectToAction("LoaiTinTuc");
        }
        public ViewResult NewsCateEdit(int id)
        {
            var newscate = db.tbnewscates.FirstOrDefault(x => x.NewscateId == id);
            return View(newscate);
        }
        [HttpPost]
        public ActionResult NewsCateEdit(Tbnewscate newscate)
        {
            db.SaveNewsCate(newscate);
            return RedirectToAction("LoaiTinTuc");
        }
        public IActionResult TinTuc()
        {
            var model = db.tbnews;
            return View(model);
        }
        public ViewResult NewsAdd()
        {
            ViewBag.Categories = db.tbnewscates;
            News model = new News();
            return View(model);
        }
        [HttpPost]
        public ActionResult NewsAdd(News model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                // If the Photo property on the incoming model object is not null, then the user
                // has selected an image to upload.
                if (model.News_image != null)
                {
                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "uploadimages");
                    // To make sure the file name is unique we are appending a new
                    // GUID value and and an underscore to the file name
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.News_image.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    // Use CopyTo() method provided by IFormFile interface to
                    // copy the file to wwwroot/images folder
                    model.News_image.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Tbnews news = new Tbnews
                {
                    NewsContent = model.NewsContent,
                    NewscateId = model.NewscateId,
                    Datecreated = model.Datecreated,
                    NewsSummary = model.NewsSummary,
                    NewsTitle = model.NewsTitle,
                    // Store the file name in PhotoPath property of the employee object
                    // which gets saved to the Employees database table
                    NewsImage = "/uploadimages/" + uniqueFileName
                };
                db.SaveNews(news);
                return RedirectToAction("TinTuc");
            }
            return View();
        }
        public ViewResult NewsEdit(int id)
        {
            ViewBag.Categories = db.tbnewscates.ToList();
            var news = db.tbnews.FirstOrDefault(x => x.NewsId == id);
            var model = new News();
            model.NewsId = news.NewsId;
            model.NewsContent = news.NewsContent;
            model.NewscateId = news.NewscateId;
            model.Datecreated = news.Datecreated;
            model.NewsSummary = news.NewsSummary;
            model.NewsTitle = news.NewsTitle;
            model.NewsLinkImage = news.NewsImage;
            return View(model);
        }
        [HttpPost]
        public ActionResult NewsEdit(News model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                // If the Photo property on the incoming model object is not null, then the user
                // has selected an image to upload.
                if (model.News_image != null)
                {
                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "uploadimages");
                    // To make sure the file name is unique we are appending a new
                    // GUID value and and an underscore to the file name
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.News_image.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    // Use CopyTo() method provided by IFormFile interface to
                    // copy the file to wwwroot/images folder
                    model.News_image.CopyTo(new FileStream(filePath, FileMode.Create));
                    var news = db.tbnews.FirstOrDefault(x => x.NewsId == model.NewsId);

                    news.NewsContent = model.NewsContent;
                    news.NewscateId = model.NewscateId;
                    news.Datecreated = model.Datecreated;
                    news.NewsSummary = model.NewsSummary;
                    news.NewsTitle = model.NewsTitle;
                    // Store the file name in PhotoPath property of the employee object
                    // which gets saved to the Employees database table
                    news.NewsImage = "/uploadimages/" + uniqueFileName;
                    db.SaveNews(news);
                }
                else
                {
                    var news = db.tbnews.FirstOrDefault(x => x.NewsId == model.NewsId);

                    news.NewsContent = model.NewsContent;
                    news.NewscateId = model.NewscateId;
                    news.Datecreated = model.Datecreated;
                    news.NewsSummary = model.NewsSummary;
                    news.NewsTitle = model.NewsTitle;
                    db.SaveNews(news);
                }
                return RedirectToAction("TinTuc");
            }
            return View();
        }
        public ActionResult NewsDelete(int id)
        {
            db.NewsDelete(id);
            return RedirectToAction("TinTuc");
        }
        public IActionResult NhomDuAn()
        {
            var model = db.tbcategories;
            return View(model);
        }
        public IActionResult DichVu()
        {
            var model = db.tbservices;
            return View(model);
        }
        public IActionResult DuAn()
        {
            var model = db.tbprojects;
            return View(model);
        }
        public IActionResult DichVuChiTiet()
        {
            var model = db.tbservicedetails;
            return View(model);
        }
        public IActionResult NhomLoai()
        {
            var model = db.tbgroupcates;
            return View(model);
        }
        public IActionResult HinhAnhDuAn()
        {
            var model = db.tbimageprojects;
            return View(model);
        }
        public IActionResult LienHeKH()
        {
            var model = db.tbcontacts;
            return View(model);
        }
        public IActionResult BaoGia()
        {
            var model = db.tbbaogias;
            return View(model);
        }
        public IActionResult BaoGiaChiTiet()
        {
            var model = db.tbbaogiachitiets;
            return View(model);
        }
        public IActionResult BaoGiaLienQuan()
        {
            var model = db.tbbaogialienquans;
            return View(model);
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}