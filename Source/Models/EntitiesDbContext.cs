using Microsoft.EntityFrameworkCore;
using Source.Models.DBF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Source.Models
{
    public class EntitiesDbContext:DbContext
    {
        public EntitiesDbContext(DbContextOptions<EntitiesDbContext> options):base(options)
        {

        }
        public DbSet<Tbadmin> tbadmins { get; set; }
        public DbSet<Tbbaivietuser> tbbaivietusers { get; set; }
        public DbSet<Tbbanggiachitietuser> tbbanggiachitietusers { get; set; }
        public DbSet<Tbbanggiagoidichvu> tbbanggiagoidichvus { get; set; }
        public DbSet<Tbbanggiauser> tbbanggiausers { get; set; }
        public DbSet<Tbbanneruser> tbbannerusers { get; set; }
        public DbSet<Tbbaogia> tbbaogias { get; set; }
        public DbSet<Tbbaogiachitiet> tbbaogiachitiets { get; set; }
        public DbSet<Tbbaogialienquan> tbbaogialienquans { get; set; }
        public DbSet<Tbcategory> tbcategories { get; set; }
        public DbSet<Tbcontact> tbcontacts { get; set; }
        public DbSet<Tbform> tbforms { get; set; }
        public DbSet<TbformAccess> tbformAccesses { get; set; }
        public DbSet<Tbgiaproject> tbgiaprojects { get; set; }
        public DbSet<Tbgroup> tbgroups { get; set; }
        public DbSet<Tbgroupcate> tbgroupcates { get; set; }
        public DbSet<Tbimageproject> tbimageprojects { get; set; }
        public DbSet<Tbintroduce> tbintroduces { get; set; }
        public DbSet<Tblanguage> tblanguages { get; set; }
        public DbSet<Tblogo> tblogos { get; set; }
        public DbSet<Tbmodule> tbmodules { get; set; }
        public DbSet<Tbnews> tbnews { get; set; }
        public DbSet<Tbnewscate> tbnewscates { get; set; }
        public DbSet<Tbproject> tbprojects { get; set; }
        public DbSet<Tbreviewscustome> tbreviewscustomes { get; set; }
        public DbSet<Tbseo> tbseos { get; set; }
        public DbSet<TbseoDetail> tbseoDetails { get; set; }
        public DbSet<Tbservice> tbservices { get; set; }
        public DbSet<Tbservicedetail> tbservicedetails { get; set; }
        public DbSet<Tbslide> tbslides { get; set; }
        public DbSet<Tbvideo> tbvideos { get; set; }
    }
}
