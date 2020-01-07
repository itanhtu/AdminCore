using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Source.Models.DBF
{
    public partial class admin_hifivetestContext : DbContext
    {
        public admin_hifivetestContext()
        {
        }

        public admin_hifivetestContext(DbContextOptions<admin_hifivetestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tbadmin> Tbadmin { get; set; }
        public virtual DbSet<Tbbaivietuser> Tbbaivietuser { get; set; }
        public virtual DbSet<Tbbanggiachitietuser> Tbbanggiachitietuser { get; set; }
        public virtual DbSet<Tbbanggiagoidichvu> Tbbanggiagoidichvu { get; set; }
        public virtual DbSet<Tbbanggiauser> Tbbanggiauser { get; set; }
        public virtual DbSet<Tbbanneruser> Tbbanneruser { get; set; }
        public virtual DbSet<Tbbaogia> Tbbaogia { get; set; }
        public virtual DbSet<Tbbaogiachitiet> Tbbaogiachitiet { get; set; }
        public virtual DbSet<Tbbaogialienquan> Tbbaogialienquan { get; set; }
        public virtual DbSet<Tbcategory> Tbcategory { get; set; }
        public virtual DbSet<Tbcontact> Tbcontact { get; set; }
        public virtual DbSet<Tbform> Tbform { get; set; }
        public virtual DbSet<TbformAccess> TbformAccess { get; set; }
        public virtual DbSet<Tbgiaproject> Tbgiaproject { get; set; }
        public virtual DbSet<Tbgroup> Tbgroup { get; set; }
        public virtual DbSet<Tbgroupcate> Tbgroupcate { get; set; }
        public virtual DbSet<Tbimageproject> Tbimageproject { get; set; }
        public virtual DbSet<Tbintroduce> Tbintroduce { get; set; }
        public virtual DbSet<Tblanguage> Tblanguage { get; set; }
        public virtual DbSet<Tblogo> Tblogo { get; set; }
        public virtual DbSet<Tbmodule> Tbmodule { get; set; }
        public virtual DbSet<Tbnews> Tbnews { get; set; }
        public virtual DbSet<Tbnewscate> Tbnewscate { get; set; }
        public virtual DbSet<Tbproject> Tbproject { get; set; }
        public virtual DbSet<Tbreviewscustome> Tbreviewscustome { get; set; }
        public virtual DbSet<Tbseo> Tbseo { get; set; }
        public virtual DbSet<TbseoDetail> TbseoDetail { get; set; }
        public virtual DbSet<Tbservice> Tbservice { get; set; }
        public virtual DbSet<Tbservicedetail> Tbservicedetail { get; set; }
        public virtual DbSet<Tbslide> Tbslide { get; set; }
        public virtual DbSet<Tbvideo> Tbvideo { get; set; }
        public virtual DbSet<abc> abcs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=171.244.3.133,1433;Database=admin_hifivetest;User Id=admin_hifivetest;Password=abc123#!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "db_owner");

            modelBuilder.Entity<Tbadmin>(entity =>
            {
                entity.HasKey(e => e.AdminEmail);

                entity.ToTable("tbadmin", "dbo");

                entity.Property(e => e.AdminEmail)
                    .HasColumnName("admin_email")
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.AdminAddress).HasColumnName("admin_address");

                entity.Property(e => e.AdminAvatar).HasColumnName("admin_avatar");

                entity.Property(e => e.AdminCode).HasColumnName("admin_code");

                entity.Property(e => e.AdminDatecreated)
                    .HasColumnName("admin_datecreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.AdminDatemodified)
                    .HasColumnName("admin_datemodified")
                    .HasColumnType("datetime");

                entity.Property(e => e.AdminDepcription).HasColumnName("admin_depcription");

                entity.Property(e => e.AdminFullcontrol).HasColumnName("admin_fullcontrol");

                entity.Property(e => e.AdminFullname).HasColumnName("admin_fullname");

                entity.Property(e => e.AdminGender).HasColumnName("admin_gender");

                entity.Property(e => e.AdminPassword).HasColumnName("admin_password");

                entity.Property(e => e.AdminPhone).HasColumnName("admin_phone");

                entity.Property(e => e.AdminPosition).HasColumnName("admin_position");

                entity.Property(e => e.AdminUsername).HasColumnName("admin_username");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Tbadmin)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__tbadmin__group_i__49C3F6B7");
            });

            modelBuilder.Entity<Tbbaivietuser>(entity =>
            {
                entity.HasKey(e => e.BaivietuserId);

                entity.ToTable("tbbaivietuser", "dbo");

                entity.Property(e => e.BaivietuserId).HasColumnName("baivietuser_id");

                entity.Property(e => e.BaivietuserContent).HasColumnName("baivietuser_content");

                entity.Property(e => e.BaivietuserTitle).HasColumnName("baivietuser_title");
            });

            modelBuilder.Entity<Tbbanggiachitietuser>(entity =>
            {
                entity.HasKey(e => e.BanggiachitietuserId);

                entity.ToTable("tbbanggiachitietuser", "dbo");

                entity.Property(e => e.BanggiachitietuserId).HasColumnName("banggiachitietuser_id");

                entity.Property(e => e.BanggiachitietuserContent).HasColumnName("banggiachitietuser_content");

                entity.Property(e => e.BanggiachitietuserTitle).HasColumnName("banggiachitietuser_title");

                entity.Property(e => e.BanggiachitietuserTitle1).HasColumnName("banggiachitietuser_title1");

                entity.Property(e => e.BanggiachitietuserTitle2).HasColumnName("banggiachitietuser_title2");

                entity.Property(e => e.BanggiachitietuserTitle3).HasColumnName("banggiachitietuser_title3");

                entity.Property(e => e.BanggiachitietuserTitle4).HasColumnName("banggiachitietuser_title4");

                entity.Property(e => e.BanggiachitietuserTitle5).HasColumnName("banggiachitietuser_title5");

                entity.Property(e => e.BanggiachitietuserTitle6).HasColumnName("banggiachitietuser_title6");

                entity.Property(e => e.BanggiachitietuserTitle7).HasColumnName("banggiachitietuser_title7");

                entity.Property(e => e.BanggiachitietuserTitle8).HasColumnName("banggiachitietuser_title8");

                entity.Property(e => e.BanggiachitietuserTitle9).HasColumnName("banggiachitietuser_title9");

                entity.Property(e => e.BanggiauserId).HasColumnName("banggiauser_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");
            });

            modelBuilder.Entity<Tbbanggiagoidichvu>(entity =>
            {
                entity.HasKey(e => e.GoidichvuId);

                entity.ToTable("tbbanggiagoidichvu", "dbo");

                entity.Property(e => e.GoidichvuId).HasColumnName("goidichvu_id");

                entity.Property(e => e.GoidichvuName).HasColumnName("goidichvu_name");

                entity.Property(e => e.Hidden).HasColumnName("hidden");
            });

            modelBuilder.Entity<Tbbanggiauser>(entity =>
            {
                entity.HasKey(e => e.BanggiauserId);

                entity.ToTable("tbbanggiauser", "dbo");

                entity.Property(e => e.BanggiauserId).HasColumnName("banggiauser_id");

                entity.Property(e => e.BanggiauserContent).HasColumnName("banggiauser_content");

                entity.Property(e => e.BanggiauserTitle).HasColumnName("banggiauser_title");

                entity.Property(e => e.BanggiauserTitle1).HasColumnName("banggiauser_title1");

                entity.Property(e => e.BanggiauserTitle2).HasColumnName("banggiauser_title2");

                entity.Property(e => e.BanggiauserTitle3).HasColumnName("banggiauser_title3");

                entity.Property(e => e.BanggiauserTitle4).HasColumnName("banggiauser_title4");

                entity.Property(e => e.BanggiauserTitle5).HasColumnName("banggiauser_title5");

                entity.Property(e => e.BanggiauserTitle6).HasColumnName("banggiauser_title6");

                entity.Property(e => e.BanggiauserTitle7).HasColumnName("banggiauser_title7");

                entity.Property(e => e.BanggiauserTitle8).HasColumnName("banggiauser_title8");

                entity.Property(e => e.BanggiauserTitle9).HasColumnName("banggiauser_title9");

                entity.Property(e => e.Goidichvu).HasColumnName("goidichvu");

                entity.Property(e => e.UserEmail).HasColumnName("user_email");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Tbbanneruser>(entity =>
            {
                entity.HasKey(e => e.BanneruserId);

                entity.ToTable("tbbanneruser", "dbo");

                entity.Property(e => e.BanneruserId).HasColumnName("banneruser_id");

                entity.Property(e => e.BanneruserImage).HasColumnName("banneruser_image");

                entity.Property(e => e.BanneruserVitri).HasColumnName("banneruser_vitri");

                entity.Property(e => e.UserEmail).HasColumnName("user_email");
            });

            modelBuilder.Entity<Tbbaogia>(entity =>
            {
                entity.HasKey(e => e.BaogiaId);

                entity.ToTable("tbbaogia", "dbo");

                entity.Property(e => e.BaogiaId).HasColumnName("baogia_id");

                entity.Property(e => e.BaogiaContent).HasColumnName("baogia_content");

                entity.Property(e => e.BaogiaTitle1).HasColumnName("baogia_title1");

                entity.Property(e => e.BaogiaTitle2).HasColumnName("baogia_title2");

                entity.Property(e => e.BaogiaTitle3).HasColumnName("baogia_title3");

                entity.Property(e => e.BaogiaTitle4).HasColumnName("baogia_title4");

                entity.Property(e => e.BaogiaTitle5).HasColumnName("baogia_title5");

                entity.Property(e => e.BaogiaTitle6).HasColumnName("baogia_title6");

                entity.Property(e => e.BaogiaTitle7).HasColumnName("baogia_title7");

                entity.Property(e => e.BaogiaTitle8).HasColumnName("baogia_title8");

                entity.Property(e => e.BaogiaTitle9).HasColumnName("baogia_title9");

                entity.Property(e => e.Hidden).HasColumnName("hidden");

                entity.Property(e => e.Position).HasColumnName("position");
            });

            modelBuilder.Entity<Tbbaogiachitiet>(entity =>
            {
                entity.HasKey(e => e.BaogiachitietId);

                entity.ToTable("tbbaogiachitiet", "dbo");

                entity.Property(e => e.BaogiachitietId).HasColumnName("baogiachitiet_id");

                entity.Property(e => e.BaogiaId).HasColumnName("baogia_id");

                entity.Property(e => e.BaogiachitietContent).HasColumnName("baogiachitiet_content");

                entity.Property(e => e.BaogiachitietTitle1).HasColumnName("baogiachitiet_title1");

                entity.Property(e => e.BaogiachitietTitle10).HasColumnName("baogiachitiet_title10");

                entity.Property(e => e.BaogiachitietTitle11).HasColumnName("baogiachitiet_title11");

                entity.Property(e => e.BaogiachitietTitle12).HasColumnName("baogiachitiet_title12");

                entity.Property(e => e.BaogiachitietTitle13).HasColumnName("baogiachitiet_title13");

                entity.Property(e => e.BaogiachitietTitle14).HasColumnName("baogiachitiet_title14");

                entity.Property(e => e.BaogiachitietTitle15).HasColumnName("baogiachitiet_title15");

                entity.Property(e => e.BaogiachitietTitle2).HasColumnName("baogiachitiet_title2");

                entity.Property(e => e.BaogiachitietTitle3).HasColumnName("baogiachitiet_title3");

                entity.Property(e => e.BaogiachitietTitle4).HasColumnName("baogiachitiet_title4");

                entity.Property(e => e.BaogiachitietTitle5).HasColumnName("baogiachitiet_title5");

                entity.Property(e => e.BaogiachitietTitle6).HasColumnName("baogiachitiet_title6");

                entity.Property(e => e.BaogiachitietTitle7).HasColumnName("baogiachitiet_title7");

                entity.Property(e => e.BaogiachitietTitle8).HasColumnName("baogiachitiet_title8");

                entity.Property(e => e.BaogiachitietTitle9).HasColumnName("baogiachitiet_title9");

                entity.Property(e => e.Hidden).HasColumnName("hidden");

                entity.Property(e => e.LangguageId).HasColumnName("langguage_id");

                entity.Property(e => e.Position).HasColumnName("position");
            });

            modelBuilder.Entity<Tbbaogialienquan>(entity =>
            {
                entity.HasKey(e => e.BaogialienquanId);

                entity.ToTable("tbbaogialienquan", "dbo");

                entity.Property(e => e.BaogialienquanId).HasColumnName("baogialienquan_id");

                entity.Property(e => e.BaogiaId).HasColumnName("baogia_id");

                entity.Property(e => e.BaogialienquanContent).HasColumnName("baogialienquan_content");

                entity.Property(e => e.BaogialienquanCreatedate)
                    .HasColumnName("baogialienquan_createdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.BaogialienquanDatemodified)
                    .HasColumnName("baogialienquan_datemodified")
                    .HasColumnType("datetime");

                entity.Property(e => e.BaogialienquanTitle).HasColumnName("baogialienquan_title");

                entity.Property(e => e.Hidden).HasColumnName("hidden");

                entity.Property(e => e.LangguageId).HasColumnName("langguage_id");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.HasOne(d => d.Baogia)
                    .WithMany(p => p.Tbbaogialienquan)
                    .HasForeignKey(d => d.BaogiaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__tbbaogial__baogi__4AB81AF0");
            });

            modelBuilder.Entity<Tbcategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("tbcategory", "dbo");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryDepcription).HasColumnName("category_depcription");

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.CategoryLevel).HasColumnName("category_level");

                entity.Property(e => e.CategoryMapped).HasColumnName("category_mapped");

                entity.Property(e => e.CategoryName).HasColumnName("category_name");

                entity.Property(e => e.CategoryParent).HasColumnName("category_parent");

                entity.Property(e => e.Datecreated)
                    .HasColumnName("datecreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datemodified)
                    .HasColumnName("datemodified")
                    .HasColumnType("datetime");

                entity.Property(e => e.GroupcateId).HasColumnName("groupcate_id");

                entity.Property(e => e.LangguageId).HasColumnName("langguage_id");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.HasOne(d => d.Groupcate)
                    .WithMany(p => p.Tbcategory)
                    .HasForeignKey(d => d.GroupcateId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__tbcategor__group__4BAC3F29");
            });

            modelBuilder.Entity<Tbcontact>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("tbcontact", "dbo");

                entity.Property(e => e.ContactId).HasColumnName("contact_id");

                entity.Property(e => e.ContactContent).HasColumnName("contact_content");

                entity.Property(e => e.ContactEmail).HasColumnName("contact_email");

                entity.Property(e => e.ContactName).HasColumnName("contact_name");

                entity.Property(e => e.ContactPhone).HasColumnName("contact_phone");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");
            });

            modelBuilder.Entity<Tbform>(entity =>
            {
                entity.HasKey(e => e.FormId);

                entity.ToTable("tbform", "dbo");

                entity.Property(e => e.FormId).HasColumnName("form_id");

                entity.Property(e => e.FormCode).HasColumnName("form_code");

                entity.Property(e => e.FormDatecreated)
                    .HasColumnName("form_datecreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.FormDatemodified)
                    .HasColumnName("form_datemodified")
                    .HasColumnType("datetime");

                entity.Property(e => e.FormDepcription).HasColumnName("form_depcription");

                entity.Property(e => e.FormIcon).HasColumnName("form_icon");

                entity.Property(e => e.FormLink).HasColumnName("form_link");

                entity.Property(e => e.FormName).HasColumnName("form_name");

                entity.Property(e => e.FormPosition).HasColumnName("form_position");

                entity.Property(e => e.ModuleId).HasColumnName("module_id");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.Tbform)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__tbform__module_i__4CA06362");
            });

            modelBuilder.Entity<TbformAccess>(entity =>
            {
                entity.HasKey(e => e.FormAccessId);

                entity.ToTable("tbform_access", "dbo");

                entity.Property(e => e.FormAccessId).HasColumnName("form_access_id");

                entity.Property(e => e.AdminEmail)
                    .HasColumnName("admin_email")
                    .HasMaxLength(100);

                entity.Property(e => e.FormAccessDatecreate)
                    .HasColumnName("form_access_datecreate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FormAccessType).HasColumnName("form_access_type");

                entity.Property(e => e.FormId).HasColumnName("form_id");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.TbformAccess)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__tbform_ac__form___4D94879B");
            });

            modelBuilder.Entity<Tbgiaproject>(entity =>
            {
                entity.HasKey(e => e.GiaprojectId);

                entity.ToTable("tbgiaproject", "dbo");

                entity.Property(e => e.GiaprojectId).HasColumnName("giaproject_id");

                entity.Property(e => e.BaogiachitietId).HasColumnName("baogiachitiet_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");
            });

            modelBuilder.Entity<Tbgroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("tbgroup", "dbo");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.GroupCode).HasColumnName("group_code");

                entity.Property(e => e.GroupDatemodified)
                    .HasColumnName("group_datemodified")
                    .HasColumnType("datetime");

                entity.Property(e => e.GroupDepcription).HasColumnName("group_depcription");

                entity.Property(e => e.GroupFullcontrol).HasColumnName("group_fullcontrol");

                entity.Property(e => e.GroupName).HasColumnName("group_name");

                entity.Property(e => e.GroupPemissionnumber).HasColumnName("group_pemissionnumber");

                entity.Property(e => e.GroupPosition).HasColumnName("group_position");
            });

            modelBuilder.Entity<Tbgroupcate>(entity =>
            {
                entity.HasKey(e => e.GroupcateId);

                entity.ToTable("tbgroupcate", "dbo");

                entity.Property(e => e.GroupcateId).HasColumnName("groupcate_id");

                entity.Property(e => e.Datecreated)
                    .HasColumnName("datecreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datemodified)
                    .HasColumnName("datemodified")
                    .HasColumnType("datetime");

                entity.Property(e => e.GroupcateDepcription).HasColumnName("groupcate_depcription");

                entity.Property(e => e.GroupcateIcon).HasColumnName("groupcate_icon");

                entity.Property(e => e.GroupcateLevel).HasColumnName("groupcate_level");

                entity.Property(e => e.GroupcateMapped).HasColumnName("groupcate_mapped");

                entity.Property(e => e.GroupcateName).HasColumnName("groupcate_name");

                entity.Property(e => e.GroupcateParent).HasColumnName("groupcate_parent");

                entity.Property(e => e.LangguageId).HasColumnName("langguage_id");

                entity.Property(e => e.Position).HasColumnName("position");
            });

            modelBuilder.Entity<Tbimageproject>(entity =>
            {
                entity.HasKey(e => e.ImageId);

                entity.ToTable("tbimageproject", "dbo");

                entity.Property(e => e.ImageId).HasColumnName("image_id");

                entity.Property(e => e.ImageLink).HasColumnName("image_link");

                entity.Property(e => e.ImageSummary).HasColumnName("image_summary");

                entity.Property(e => e.ImageTitle).HasColumnName("image_title");

                entity.Property(e => e.LangguageId).HasColumnName("langguage_id");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Tbimageproject)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__tbimagepr__proje__4E88ABD4");
            });

            modelBuilder.Entity<Tbintroduce>(entity =>
            {
                entity.HasKey(e => e.IntroId);

                entity.ToTable("tbintroduce", "dbo");

                entity.Property(e => e.IntroId).HasColumnName("intro_id");

                entity.Property(e => e.IntroAuthor).HasColumnName("intro_author");

                entity.Property(e => e.IntroConntent).HasColumnName("intro_conntent");

                entity.Property(e => e.IntroCreatedate)
                    .HasColumnName("intro_createdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntroDatemodified)
                    .HasColumnName("intro_datemodified")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntroImage).HasColumnName("intro_image");

                entity.Property(e => e.IntroSummary).HasColumnName("intro_summary");

                entity.Property(e => e.IntroTitle).HasColumnName("intro_title");

                entity.Property(e => e.LangguageId).HasColumnName("langguage_id");

                entity.Property(e => e.Position).HasColumnName("position");
            });

            modelBuilder.Entity<Tblanguage>(entity =>
            {
                entity.HasKey(e => e.LangguageId);

                entity.ToTable("tblanguage", "dbo");

                entity.Property(e => e.LangguageId).HasColumnName("langguage_id");

                entity.Property(e => e.Datemodified)
                    .HasColumnName("datemodified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dtecreated)
                    .HasColumnName("dtecreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.LanguageCode).HasColumnName("language_code");

                entity.Property(e => e.LanguageIcon).HasColumnName("language_icon");

                entity.Property(e => e.LanguageName).HasColumnName("language_name");

                entity.Property(e => e.Position).HasColumnName("position");
            });

            modelBuilder.Entity<Tblogo>(entity =>
            {
                entity.HasKey(e => e.LogoId);

                entity.ToTable("tblogo", "dbo");

                entity.Property(e => e.LogoId).HasColumnName("logo_id");

                entity.Property(e => e.LogoImage).HasColumnName("logo_image");

                entity.Property(e => e.LogoLink).HasColumnName("logo_link");

                entity.Property(e => e.LogoName).HasColumnName("logo_name");
            });

            modelBuilder.Entity<Tbmodule>(entity =>
            {
                entity.HasKey(e => e.ModuleId);

                entity.ToTable("tbmodule", "dbo");

                entity.Property(e => e.ModuleId).HasColumnName("module_id");

                entity.Property(e => e.ModuleCode).HasColumnName("module_code");

                entity.Property(e => e.ModuleDatemodified)
                    .HasColumnName("module_datemodified")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModuleDepcription).HasColumnName("module_depcription");

                entity.Property(e => e.ModuleIcon).HasColumnName("module_icon");

                entity.Property(e => e.ModuleLevel).HasColumnName("module_level");

                entity.Property(e => e.ModuleLink).HasColumnName("module_link");

                entity.Property(e => e.ModuleName).HasColumnName("module_name");

                entity.Property(e => e.ModuleParent).HasColumnName("module_parent");

                entity.Property(e => e.ModulePosition).HasColumnName("module_position");
            });

            modelBuilder.Entity<Tbnews>(entity =>
            {
                entity.HasKey(e => e.NewsId);

                entity.ToTable("tbnews", "dbo");

                entity.Property(e => e.NewsId).HasColumnName("news_id");

                entity.Property(e => e.Datecreated)
                    .HasColumnName("datecreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datemodified)
                    .HasColumnName("datemodified")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hidden).HasColumnName("hidden");

                entity.Property(e => e.LangguageId).HasColumnName("langguage_id");

                entity.Property(e => e.NewsAuthor).HasColumnName("news_author");

                entity.Property(e => e.NewsContent).HasColumnName("news_content");

                entity.Property(e => e.NewsImage).HasColumnName("news_image");

                entity.Property(e => e.NewsImagename).HasColumnName("news_imagename");

                entity.Property(e => e.NewsLink).HasColumnName("news_link");

                entity.Property(e => e.NewsName).HasColumnName("news_name");

                entity.Property(e => e.NewsNote).HasColumnName("news_note");

                entity.Property(e => e.NewsSummary).HasColumnName("news_summary");

                entity.Property(e => e.NewsTitle).HasColumnName("news_title");

                entity.Property(e => e.NewscateId).HasColumnName("newscate_id");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.HasOne(d => d.Newscate)
                    .WithMany(p => p.Tbnews)
                    .HasForeignKey(d => d.NewscateId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__tbnews__newscate__4F7CD00D");
            });

            modelBuilder.Entity<Tbnewscate>(entity =>
            {
                entity.HasKey(e => e.NewscateId);

                entity.ToTable("tbnewscate", "dbo");

                entity.Property(e => e.NewscateId).HasColumnName("newscate_id");

                entity.Property(e => e.LangguageId).HasColumnName("langguage_id");

                entity.Property(e => e.NewscateImagename).HasColumnName("newscate_imagename");

                entity.Property(e => e.NewscateLink).HasColumnName("newscate_link");

                entity.Property(e => e.NewscateName).HasColumnName("newscate_name");

                entity.Property(e => e.NewscateNote).HasColumnName("newscate_note");

                entity.Property(e => e.Position).HasColumnName("position");
            });

            modelBuilder.Entity<Tbproject>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.ToTable("tbproject", "dbo");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.LangguageId).HasColumnName("langguage_id");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.ProjectContent).HasColumnName("project_content");

                entity.Property(e => e.ProjectHidden).HasColumnName("project_hidden");

                entity.Property(e => e.ProjectImage).HasColumnName("project_image");

                entity.Property(e => e.ProjectLink).HasColumnName("project_link");

                entity.Property(e => e.ProjectName).HasColumnName("project_name");

                entity.Property(e => e.ProjectPrice).HasColumnName("project_price");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Tbproject)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__tbproject__categ__5070F446");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Tbproject)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__tbproject__servi__5165187F");
            });

            modelBuilder.Entity<Tbreviewscustome>(entity =>
            {
                entity.HasKey(e => e.ReviewsId);

                entity.ToTable("tbreviewscustome", "dbo");

                entity.Property(e => e.ReviewsId).HasColumnName("reviews_id");

                entity.Property(e => e.Hidden).HasColumnName("hidden");

                entity.Property(e => e.LangguageId).HasColumnName("langguage_id");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.ReviewContent).HasColumnName("review_content");

                entity.Property(e => e.ReviewCreatedated)
                    .HasColumnName("review_createdated")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReviewIcon).HasColumnName("review_icon");

                entity.Property(e => e.ReviewName).HasColumnName("review_name");
            });

            modelBuilder.Entity<Tbseo>(entity =>
            {
                entity.HasKey(e => e.SeoId);

                entity.ToTable("tbseo", "dbo");

                entity.Property(e => e.SeoId).HasColumnName("seo_id");

                entity.Property(e => e.SeoModifieddate)
                    .HasColumnName("seo_modifieddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SeoName).HasColumnName("seo_name");

                entity.Property(e => e.SeoUrl).HasColumnName("seo_url");
            });

            modelBuilder.Entity<TbseoDetail>(entity =>
            {
                entity.HasKey(e => e.SeodetailId);

                entity.ToTable("tbseo_detail", "dbo");

                entity.Property(e => e.SeodetailId).HasColumnName("seodetail_id");

                entity.Property(e => e.Objectguid).HasColumnName("objectguid");

                entity.Property(e => e.SeoGuid).HasColumnName("seo_guid");

                entity.Property(e => e.SeoId).HasColumnName("seo_id");

                entity.Property(e => e.SeoModifieddate)
                    .HasColumnName("seo_modifieddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SeodetailContent).HasColumnName("seodetail_content");

                entity.HasOne(d => d.Seo)
                    .WithMany(p => p.TbseoDetail)
                    .HasForeignKey(d => d.SeoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__tbseo_det__seo_i__52593CB8");
            });

            modelBuilder.Entity<Tbservice>(entity =>
            {
                entity.HasKey(e => e.ServiceId);

                entity.ToTable("tbservice", "dbo");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.LangguageId).HasColumnName("langguage_id");

                entity.Property(e => e.ServiceContent).HasColumnName("service_content");

                entity.Property(e => e.ServiceCreatedate)
                    .HasColumnName("service_createdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ServiceDatemodified)
                    .HasColumnName("service_datemodified")
                    .HasColumnType("datetime");

                entity.Property(e => e.ServiceHidden).HasColumnName("service_hidden");

                entity.Property(e => e.ServiceImage).HasColumnName("service_image");

                entity.Property(e => e.ServiceLink).HasColumnName("service_link");

                entity.Property(e => e.ServiceSummary).HasColumnName("service_summary");

                entity.Property(e => e.ServiceTitle).HasColumnName("service_title");
            });

            modelBuilder.Entity<Tbservicedetail>(entity =>
            {
                entity.HasKey(e => e.ServicedetailId);

                entity.ToTable("tbservicedetail", "dbo");

                entity.Property(e => e.ServicedetailId).HasColumnName("servicedetail_id");

                entity.Property(e => e.Hidden).HasColumnName("hidden");

                entity.Property(e => e.LangguageId).HasColumnName("langguage_id");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.ServicedetailContent).HasColumnName("servicedetail_content");

                entity.Property(e => e.ServicedetailCreatedate)
                    .HasColumnName("servicedetail_createdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ServicedetailDatemodified)
                    .HasColumnName("servicedetail_datemodified")
                    .HasColumnType("datetime");

                entity.Property(e => e.ServicedetailTitle).HasColumnName("servicedetail_title");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Tbservicedetail)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__tbservice__servi__534D60F1");
            });

            modelBuilder.Entity<Tbslide>(entity =>
            {
                entity.HasKey(e => e.SlideId);

                entity.ToTable("tbslide", "dbo");

                entity.Property(e => e.SlideId).HasColumnName("slide_id");

                entity.Property(e => e.SlideImage).HasColumnName("slide_image");

                entity.Property(e => e.SlideLink).HasColumnName("slide_link");

                entity.Property(e => e.SlideTitle1).HasColumnName("slide_title1");

                entity.Property(e => e.SlideTitle2).HasColumnName("slide_title2");

                entity.Property(e => e.SlideTitle3).HasColumnName("slide_title3");
            });

            modelBuilder.Entity<Tbvideo>(entity =>
            {
                entity.HasKey(e => e.VideoId);

                entity.ToTable("tbvideo", "dbo");

                entity.Property(e => e.VideoId).HasColumnName("video_id");

                entity.Property(e => e.LangguageId).HasColumnName("langguage_id");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.VideoContent).HasColumnName("video_content");

                entity.Property(e => e.VideoCreatedate)
                    .HasColumnName("video_createdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.VideoDatemodified)
                    .HasColumnName("video_datemodified")
                    .HasColumnType("datetime");

                entity.Property(e => e.VideoImage).HasColumnName("video_image");

                entity.Property(e => e.VideoLink).HasColumnName("video_link");

                entity.Property(e => e.VideoSummary).HasColumnName("video_summary");

                entity.Property(e => e.VideoTitle).HasColumnName("video_title");
            });
        }
    }
}
