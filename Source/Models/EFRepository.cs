using Source.Models.DBF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Source.Models
{
    public class EFRepository : IRepository
    {
        private admin_hifivetestContext context;
        public EFRepository(admin_hifivetestContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Tbadmin> tbadmins => context.Tbadmin;
        public IQueryable<Tbbaivietuser> tbbaivietusers => context.Tbbaivietuser;
        public IQueryable<Tbbanggiachitietuser> tbbanggiachitietusers => context.Tbbanggiachitietuser;
        public IQueryable<Tbbanggiagoidichvu> tbbanggiagoidichvus => context.Tbbanggiagoidichvu;
        public IQueryable<Tbbanggiauser> tbbanggiausers => context.Tbbanggiauser;
        public IQueryable<Tbbanneruser> tbbannerusers => context.Tbbanneruser;
        public IQueryable<Tbbaogia> tbbaogias => context.Tbbaogia;
        public IQueryable<Tbbaogiachitiet> tbbaogiachitiets => context.Tbbaogiachitiet;
        public IQueryable<Tbbaogialienquan> tbbaogialienquans => context.Tbbaogialienquan;
        public IQueryable<Tbcategory> tbcategories => context.Tbcategory;
        public IQueryable<Tbcontact> tbcontacts => context.Tbcontact;
        public IQueryable<Tbform> tbforms => context.Tbform;
        public IQueryable<TbformAccess> tbformAccesses => context.TbformAccess;
        public IQueryable<Tbgiaproject> tbgiaprojects => context.Tbgiaproject;
        public IQueryable<Tbgroup> tbgroups => context.Tbgroup;
        public IQueryable<Tbgroupcate> tbgroupcates => context.Tbgroupcate;
        public IQueryable<Tbimageproject> tbimageprojects => context.Tbimageproject;
        public IQueryable<Tbintroduce> tbintroduces => context.Tbintroduce;
        public IQueryable<Tblanguage> tblanguages => context.Tblanguage;
        public IQueryable<Tblogo> tblogos => context.Tblogo;
        public IQueryable<Tbmodule> tbmodules => context.Tbmodule;
        public IQueryable<Tbnews> tbnews => context.Tbnews;
        public IQueryable<Tbnewscate> tbnewscates => context.Tbnewscate;
        public IQueryable<Tbproject> tbprojects => context.Tbproject;
        public IQueryable<Tbreviewscustome> tbreviewscustomes => context.Tbreviewscustome;
        public IQueryable<Tbseo> tbseos => context.Tbseo;
        public IQueryable<TbseoDetail> tbseoDetails => context.TbseoDetail;
        public IQueryable<Tbservice> tbservices => context.Tbservice;
        public IQueryable<Tbservicedetail> tbservicedetails => context.Tbservicedetail;
        public IQueryable<Tbslide> tbslides => context.Tbslide;
        public IQueryable<Tbvideo> tbvideos => context.Tbvideo;
        public IQueryable<abc> abcs => context.abcs;
        public void SaveNewsCate(Tbnewscate newscate)
        {
            if (newscate.NewscateId == 0)
            {
                context.Tbnewscate.Add(newscate);
            }
            else
            {
                Tbnewscate newcate = context.Tbnewscate
                    .FirstOrDefault(p => p.NewscateId == newscate.NewscateId);
                if (newcate != null)
                {
                    newcate.NewscateName = newscate.NewscateName;
                    newcate.NewscateNote = newscate.NewscateNote;
                }
            }
            context.SaveChanges();
        }
        public void NewsCateDelete(int newscate_id)
        {
            var newscate = context.Tbnewscate.FirstOrDefault(x => x.NewscateId == newscate_id);
            if(newscate!=null)
            {
                context.Tbnewscate.Remove(newscate);
                context.SaveChanges();
            }
        }
        public void SaveNews(Tbnews model)
        {
            if (model.NewsId == 0)
            {
                context.Tbnews.Add(model);
            }
            else
            {
                Tbnews news = context.Tbnews
                    .FirstOrDefault(p => p.NewsId == model.NewsId);
                if (news != null)
                {
                    news.NewsContent = model.NewsContent;
                    news.NewscateId = model.NewscateId;
                    news.Datecreated = model.Datecreated;
                    news.NewsSummary = model.NewsSummary;
                    news.NewsTitle = model.NewsTitle;
                    news.NewsImage = model.NewsImage;
                    news.Datemodified = DateTime.Now;
                }
            }
            context.SaveChanges();
        }
        public void NewsDelete(int news_id)
        {
            var news = context.Tbnews.FirstOrDefault(x => x.NewsId == news_id);
            if (news != null)
            {
                context.Tbnews.Remove(news);
                context.SaveChanges();
            }
        }
    }
}
