using Source.Models.DBF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Source.Models
{
    public interface IRepository
    {
        IQueryable<Tbadmin> tbadmins { get; }
        IQueryable<Tbbaivietuser> tbbaivietusers { get; }
        IQueryable<Tbbanggiachitietuser> tbbanggiachitietusers { get; }
        IQueryable<Tbbanggiagoidichvu> tbbanggiagoidichvus { get; }
        IQueryable<Tbbanggiauser> tbbanggiausers { get; }
        IQueryable<Tbbanneruser> tbbannerusers { get; }
        IQueryable<Tbbaogia> tbbaogias { get; }
        IQueryable<Tbbaogiachitiet> tbbaogiachitiets { get; }
        IQueryable<Tbbaogialienquan> tbbaogialienquans { get; }
        IQueryable<Tbcategory> tbcategories { get; }
        IQueryable<Tbcontact> tbcontacts { get; }
        IQueryable<Tbform> tbforms { get; }
        IQueryable<TbformAccess> tbformAccesses { get; }
        IQueryable<Tbgiaproject> tbgiaprojects { get; }
        IQueryable<Tbgroup> tbgroups { get; }
        IQueryable<Tbgroupcate> tbgroupcates { get; }
        IQueryable<Tbimageproject> tbimageprojects { get; }
        IQueryable<Tbintroduce> tbintroduces { get; }
        IQueryable<Tblanguage> tblanguages { get; }
        IQueryable<Tblogo> tblogos { get; }
        IQueryable<Tbmodule> tbmodules { get; }
        IQueryable<Tbnews> tbnews { get; }
        IQueryable<Tbnewscate> tbnewscates { get; }
        IQueryable<Tbproject> tbprojects { get; }
        IQueryable<Tbreviewscustome> tbreviewscustomes { get; }
        IQueryable<Tbseo> tbseos { get; }
        IQueryable<TbseoDetail> tbseoDetails { get; }
        IQueryable<Tbservice> tbservices { get; }
        IQueryable<Tbservicedetail> tbservicedetails { get; }
        IQueryable<Tbslide> tbslides { get; }
        IQueryable<Tbvideo> tbvideos { get; }
        IQueryable<abc> abcs { get; }
        void SaveNewsCate(Tbnewscate newscate);
        void NewsCateDelete(int newscate_id);
        void SaveNews(Tbnews news);
        void NewsDelete(int newscate_id);
    }
}
