using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Source.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "db_owner");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "abcs",
                schema: "db_owner",
                columns: table => new
                {
                    abc_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abcs", x => x.abc_id);
                });

            migrationBuilder.CreateTable(
                name: "tbbaivietuser",
                schema: "dbo",
                columns: table => new
                {
                    baivietuser_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    baivietuser_title = table.Column<string>(nullable: true),
                    baivietuser_content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbbaivietuser", x => x.baivietuser_id);
                });

            migrationBuilder.CreateTable(
                name: "tbbanggiachitietuser",
                schema: "dbo",
                columns: table => new
                {
                    banggiachitietuser_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    banggiachitietuser_title = table.Column<string>(nullable: true),
                    banggiachitietuser_title1 = table.Column<string>(nullable: true),
                    banggiachitietuser_title2 = table.Column<string>(nullable: true),
                    banggiachitietuser_title3 = table.Column<string>(nullable: true),
                    banggiachitietuser_title4 = table.Column<string>(nullable: true),
                    banggiachitietuser_title5 = table.Column<string>(nullable: true),
                    banggiachitietuser_title6 = table.Column<string>(nullable: true),
                    banggiachitietuser_title7 = table.Column<string>(nullable: true),
                    banggiachitietuser_title8 = table.Column<string>(nullable: true),
                    banggiachitietuser_title9 = table.Column<string>(nullable: true),
                    banggiachitietuser_content = table.Column<string>(nullable: true),
                    banggiauser_id = table.Column<int>(nullable: true),
                    project_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbbanggiachitietuser", x => x.banggiachitietuser_id);
                });

            migrationBuilder.CreateTable(
                name: "tbbanggiagoidichvu",
                schema: "dbo",
                columns: table => new
                {
                    goidichvu_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    goidichvu_name = table.Column<string>(nullable: true),
                    hidden = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbbanggiagoidichvu", x => x.goidichvu_id);
                });

            migrationBuilder.CreateTable(
                name: "tbbanggiauser",
                schema: "dbo",
                columns: table => new
                {
                    banggiauser_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    banggiauser_title = table.Column<string>(nullable: true),
                    banggiauser_title1 = table.Column<string>(nullable: true),
                    banggiauser_title2 = table.Column<string>(nullable: true),
                    banggiauser_title3 = table.Column<string>(nullable: true),
                    banggiauser_title4 = table.Column<string>(nullable: true),
                    banggiauser_title5 = table.Column<string>(nullable: true),
                    banggiauser_title6 = table.Column<string>(nullable: true),
                    banggiauser_title7 = table.Column<string>(nullable: true),
                    banggiauser_title8 = table.Column<string>(nullable: true),
                    banggiauser_title9 = table.Column<string>(nullable: true),
                    banggiauser_content = table.Column<string>(nullable: true),
                    user_id = table.Column<int>(nullable: true),
                    user_email = table.Column<string>(nullable: true),
                    goidichvu = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbbanggiauser", x => x.banggiauser_id);
                });

            migrationBuilder.CreateTable(
                name: "tbbanneruser",
                schema: "dbo",
                columns: table => new
                {
                    banneruser_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    banneruser_image = table.Column<string>(nullable: true),
                    user_email = table.Column<string>(nullable: true),
                    banneruser_vitri = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbbanneruser", x => x.banneruser_id);
                });

            migrationBuilder.CreateTable(
                name: "tbbaogia",
                schema: "dbo",
                columns: table => new
                {
                    baogia_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    baogia_title1 = table.Column<string>(nullable: true),
                    baogia_title2 = table.Column<string>(nullable: true),
                    baogia_title3 = table.Column<string>(nullable: true),
                    baogia_title4 = table.Column<string>(nullable: true),
                    baogia_title5 = table.Column<string>(nullable: true),
                    baogia_title6 = table.Column<string>(nullable: true),
                    baogia_title7 = table.Column<string>(nullable: true),
                    baogia_title8 = table.Column<string>(nullable: true),
                    baogia_title9 = table.Column<string>(nullable: true),
                    baogia_content = table.Column<string>(nullable: true),
                    position = table.Column<int>(nullable: true),
                    hidden = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbbaogia", x => x.baogia_id);
                });

            migrationBuilder.CreateTable(
                name: "tbbaogiachitiet",
                schema: "dbo",
                columns: table => new
                {
                    baogiachitiet_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    baogiachitiet_title1 = table.Column<string>(nullable: true),
                    baogiachitiet_title2 = table.Column<string>(nullable: true),
                    baogiachitiet_title3 = table.Column<string>(nullable: true),
                    baogiachitiet_title4 = table.Column<string>(nullable: true),
                    baogiachitiet_title5 = table.Column<string>(nullable: true),
                    baogiachitiet_title6 = table.Column<string>(nullable: true),
                    baogiachitiet_title7 = table.Column<string>(nullable: true),
                    baogiachitiet_title8 = table.Column<string>(nullable: true),
                    baogiachitiet_title9 = table.Column<string>(nullable: true),
                    baogiachitiet_title10 = table.Column<string>(nullable: true),
                    baogiachitiet_title11 = table.Column<string>(nullable: true),
                    baogiachitiet_title12 = table.Column<string>(nullable: true),
                    baogiachitiet_title13 = table.Column<string>(nullable: true),
                    baogiachitiet_title14 = table.Column<string>(nullable: true),
                    baogiachitiet_title15 = table.Column<string>(nullable: true),
                    baogiachitiet_content = table.Column<string>(nullable: true),
                    position = table.Column<int>(nullable: true),
                    baogia_id = table.Column<int>(nullable: true),
                    langguage_id = table.Column<int>(nullable: true),
                    hidden = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbbaogiachitiet", x => x.baogiachitiet_id);
                });

            migrationBuilder.CreateTable(
                name: "tbcontact",
                schema: "dbo",
                columns: table => new
                {
                    contact_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    contact_name = table.Column<string>(nullable: true),
                    contact_phone = table.Column<string>(nullable: true),
                    contact_email = table.Column<string>(nullable: true),
                    contact_content = table.Column<string>(nullable: true),
                    project_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbcontact", x => x.contact_id);
                });

            migrationBuilder.CreateTable(
                name: "tbgiaproject",
                schema: "dbo",
                columns: table => new
                {
                    giaproject_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    baogiachitiet_id = table.Column<int>(nullable: true),
                    project_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbgiaproject", x => x.giaproject_id);
                });

            migrationBuilder.CreateTable(
                name: "tbgroup",
                schema: "dbo",
                columns: table => new
                {
                    group_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    group_name = table.Column<string>(nullable: true),
                    group_position = table.Column<int>(nullable: true),
                    group_depcription = table.Column<string>(nullable: true),
                    group_pemissionnumber = table.Column<int>(nullable: true),
                    group_datemodified = table.Column<DateTime>(type: "datetime", nullable: true),
                    group_fullcontrol = table.Column<bool>(nullable: true),
                    group_code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbgroup", x => x.group_id);
                });

            migrationBuilder.CreateTable(
                name: "tbgroupcate",
                schema: "dbo",
                columns: table => new
                {
                    groupcate_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    groupcate_name = table.Column<string>(nullable: true),
                    groupcate_depcription = table.Column<string>(nullable: true),
                    groupcate_icon = table.Column<string>(nullable: true),
                    groupcate_parent = table.Column<int>(nullable: true),
                    groupcate_mapped = table.Column<string>(nullable: true),
                    groupcate_level = table.Column<int>(nullable: true),
                    langguage_id = table.Column<int>(nullable: true),
                    position = table.Column<int>(nullable: true),
                    datecreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    datemodified = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbgroupcate", x => x.groupcate_id);
                });

            migrationBuilder.CreateTable(
                name: "tbintroduce",
                schema: "dbo",
                columns: table => new
                {
                    intro_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    intro_title = table.Column<string>(nullable: true),
                    intro_image = table.Column<string>(nullable: true),
                    intro_summary = table.Column<string>(nullable: true),
                    intro_conntent = table.Column<string>(nullable: true),
                    intro_author = table.Column<string>(nullable: true),
                    intro_createdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    intro_datemodified = table.Column<DateTime>(type: "datetime", nullable: true),
                    langguage_id = table.Column<int>(nullable: true),
                    position = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbintroduce", x => x.intro_id);
                });

            migrationBuilder.CreateTable(
                name: "tblanguage",
                schema: "dbo",
                columns: table => new
                {
                    langguage_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    language_name = table.Column<string>(nullable: true),
                    language_icon = table.Column<string>(nullable: true),
                    language_code = table.Column<string>(nullable: true),
                    dtecreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    datemodified = table.Column<DateTime>(type: "datetime", nullable: true),
                    position = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblanguage", x => x.langguage_id);
                });

            migrationBuilder.CreateTable(
                name: "tblogo",
                schema: "dbo",
                columns: table => new
                {
                    logo_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    logo_image = table.Column<string>(nullable: true),
                    logo_name = table.Column<string>(nullable: true),
                    logo_link = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblogo", x => x.logo_id);
                });

            migrationBuilder.CreateTable(
                name: "tbmodule",
                schema: "dbo",
                columns: table => new
                {
                    module_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    module_name = table.Column<string>(nullable: true),
                    module_parent = table.Column<int>(nullable: true),
                    module_level = table.Column<int>(nullable: true),
                    module_position = table.Column<int>(nullable: true),
                    module_icon = table.Column<string>(nullable: true),
                    module_depcription = table.Column<string>(nullable: true),
                    module_link = table.Column<string>(nullable: true),
                    module_code = table.Column<string>(nullable: true),
                    module_datemodified = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbmodule", x => x.module_id);
                });

            migrationBuilder.CreateTable(
                name: "tbnewscate",
                schema: "dbo",
                columns: table => new
                {
                    newscate_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    newscate_name = table.Column<string>(nullable: true),
                    position = table.Column<int>(nullable: true),
                    newscate_imagename = table.Column<string>(nullable: true),
                    newscate_link = table.Column<string>(nullable: true),
                    newscate_note = table.Column<string>(nullable: true),
                    langguage_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbnewscate", x => x.newscate_id);
                });

            migrationBuilder.CreateTable(
                name: "tbreviewscustome",
                schema: "dbo",
                columns: table => new
                {
                    reviews_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    review_name = table.Column<string>(nullable: true),
                    review_icon = table.Column<string>(nullable: true),
                    review_createdated = table.Column<DateTime>(type: "datetime", nullable: true),
                    review_content = table.Column<string>(nullable: true),
                    position = table.Column<int>(nullable: true),
                    langguage_id = table.Column<int>(nullable: true),
                    hidden = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbreviewscustome", x => x.reviews_id);
                });

            migrationBuilder.CreateTable(
                name: "tbseo",
                schema: "dbo",
                columns: table => new
                {
                    seo_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    seo_name = table.Column<string>(nullable: true),
                    seo_url = table.Column<string>(nullable: true),
                    seo_modifieddate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbseo", x => x.seo_id);
                });

            migrationBuilder.CreateTable(
                name: "tbservice",
                schema: "dbo",
                columns: table => new
                {
                    service_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    service_title = table.Column<string>(nullable: true),
                    service_summary = table.Column<string>(nullable: true),
                    service_image = table.Column<string>(nullable: true),
                    service_link = table.Column<string>(nullable: true),
                    service_content = table.Column<string>(nullable: true),
                    service_createdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    service_datemodified = table.Column<DateTime>(type: "datetime", nullable: true),
                    langguage_id = table.Column<int>(nullable: true),
                    service_hidden = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbservice", x => x.service_id);
                });

            migrationBuilder.CreateTable(
                name: "tbslide",
                schema: "dbo",
                columns: table => new
                {
                    slide_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    slide_image = table.Column<string>(nullable: true),
                    slide_title1 = table.Column<string>(nullable: true),
                    slide_title2 = table.Column<string>(nullable: true),
                    slide_title3 = table.Column<string>(nullable: true),
                    slide_link = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbslide", x => x.slide_id);
                });

            migrationBuilder.CreateTable(
                name: "tbvideo",
                schema: "dbo",
                columns: table => new
                {
                    video_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    video_title = table.Column<string>(nullable: true),
                    video_summary = table.Column<string>(nullable: true),
                    video_image = table.Column<string>(nullable: true),
                    video_link = table.Column<string>(nullable: true),
                    video_content = table.Column<string>(nullable: true),
                    video_createdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    video_datemodified = table.Column<DateTime>(type: "datetime", nullable: true),
                    langguage_id = table.Column<int>(nullable: true),
                    position = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbvideo", x => x.video_id);
                });

            migrationBuilder.CreateTable(
                name: "tbbaogialienquan",
                schema: "dbo",
                columns: table => new
                {
                    baogialienquan_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    baogialienquan_title = table.Column<string>(nullable: true),
                    baogialienquan_content = table.Column<string>(nullable: true),
                    baogialienquan_createdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    baogialienquan_datemodified = table.Column<DateTime>(type: "datetime", nullable: true),
                    position = table.Column<int>(nullable: true),
                    hidden = table.Column<bool>(nullable: true),
                    langguage_id = table.Column<int>(nullable: true),
                    baogia_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbbaogialienquan", x => x.baogialienquan_id);
                    table.ForeignKey(
                        name: "FK__tbbaogial__baogi__4AB81AF0",
                        column: x => x.baogia_id,
                        principalSchema: "dbo",
                        principalTable: "tbbaogia",
                        principalColumn: "baogia_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbadmin",
                schema: "dbo",
                columns: table => new
                {
                    admin_email = table.Column<string>(maxLength: 100, nullable: false),
                    admin_password = table.Column<string>(nullable: true),
                    admin_fullname = table.Column<string>(nullable: true),
                    admin_gender = table.Column<bool>(nullable: true),
                    admin_phone = table.Column<string>(nullable: true),
                    admin_address = table.Column<string>(nullable: true),
                    admin_avatar = table.Column<string>(nullable: true),
                    admin_depcription = table.Column<string>(nullable: true),
                    admin_position = table.Column<int>(nullable: true),
                    admin_datemodified = table.Column<DateTime>(type: "datetime", nullable: true),
                    admin_datecreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    admin_code = table.Column<string>(nullable: true),
                    admin_fullcontrol = table.Column<bool>(nullable: true),
                    admin_username = table.Column<string>(nullable: true),
                    group_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbadmin", x => x.admin_email);
                    table.ForeignKey(
                        name: "FK__tbadmin__group_i__49C3F6B7",
                        column: x => x.group_id,
                        principalSchema: "dbo",
                        principalTable: "tbgroup",
                        principalColumn: "group_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbcategory",
                schema: "dbo",
                columns: table => new
                {
                    category_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    category_name = table.Column<string>(nullable: true),
                    category_depcription = table.Column<string>(nullable: true),
                    category_icon = table.Column<string>(nullable: true),
                    category_parent = table.Column<int>(nullable: true),
                    category_mapped = table.Column<string>(nullable: true),
                    category_level = table.Column<int>(nullable: true),
                    langguage_id = table.Column<int>(nullable: true),
                    position = table.Column<int>(nullable: true),
                    datecreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    datemodified = table.Column<DateTime>(type: "datetime", nullable: true),
                    groupcate_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbcategory", x => x.category_id);
                    table.ForeignKey(
                        name: "FK__tbcategor__group__4BAC3F29",
                        column: x => x.groupcate_id,
                        principalSchema: "dbo",
                        principalTable: "tbgroupcate",
                        principalColumn: "groupcate_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbform",
                schema: "dbo",
                columns: table => new
                {
                    form_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    form_name = table.Column<string>(nullable: true),
                    form_link = table.Column<string>(nullable: true),
                    form_position = table.Column<int>(nullable: true),
                    form_icon = table.Column<string>(nullable: true),
                    form_depcription = table.Column<string>(nullable: true),
                    form_datecreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    form_datemodified = table.Column<DateTime>(type: "datetime", nullable: true),
                    form_code = table.Column<string>(nullable: true),
                    module_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbform", x => x.form_id);
                    table.ForeignKey(
                        name: "FK__tbform__module_i__4CA06362",
                        column: x => x.module_id,
                        principalSchema: "dbo",
                        principalTable: "tbmodule",
                        principalColumn: "module_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbnews",
                schema: "dbo",
                columns: table => new
                {
                    news_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    news_name = table.Column<string>(nullable: true),
                    position = table.Column<int>(nullable: true),
                    news_imagename = table.Column<string>(nullable: true),
                    news_image = table.Column<string>(nullable: true),
                    news_link = table.Column<string>(nullable: true),
                    news_note = table.Column<string>(nullable: true),
                    news_title = table.Column<string>(nullable: true),
                    newscate_id = table.Column<int>(nullable: true),
                    news_content = table.Column<string>(nullable: true),
                    news_summary = table.Column<string>(nullable: true),
                    news_author = table.Column<string>(nullable: true),
                    datecreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    datemodified = table.Column<DateTime>(type: "datetime", nullable: true),
                    langguage_id = table.Column<int>(nullable: true),
                    hidden = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbnews", x => x.news_id);
                    table.ForeignKey(
                        name: "FK__tbnews__newscate__4F7CD00D",
                        column: x => x.newscate_id,
                        principalSchema: "dbo",
                        principalTable: "tbnewscate",
                        principalColumn: "newscate_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbseo_detail",
                schema: "dbo",
                columns: table => new
                {
                    seodetail_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    seo_guid = table.Column<Guid>(nullable: true),
                    objectguid = table.Column<string>(nullable: true),
                    seodetail_content = table.Column<string>(nullable: true),
                    seo_modifieddate = table.Column<DateTime>(type: "datetime", nullable: true),
                    seo_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbseo_detail", x => x.seodetail_id);
                    table.ForeignKey(
                        name: "FK__tbseo_det__seo_i__52593CB8",
                        column: x => x.seo_id,
                        principalSchema: "dbo",
                        principalTable: "tbseo",
                        principalColumn: "seo_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbservicedetail",
                schema: "dbo",
                columns: table => new
                {
                    servicedetail_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    servicedetail_title = table.Column<string>(nullable: true),
                    servicedetail_content = table.Column<string>(nullable: true),
                    servicedetail_createdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    servicedetail_datemodified = table.Column<DateTime>(type: "datetime", nullable: true),
                    position = table.Column<int>(nullable: true),
                    hidden = table.Column<bool>(nullable: true),
                    langguage_id = table.Column<int>(nullable: true),
                    service_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbservicedetail", x => x.servicedetail_id);
                    table.ForeignKey(
                        name: "FK__tbservice__servi__534D60F1",
                        column: x => x.service_id,
                        principalSchema: "dbo",
                        principalTable: "tbservice",
                        principalColumn: "service_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbproject",
                schema: "dbo",
                columns: table => new
                {
                    project_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    project_name = table.Column<string>(nullable: true),
                    project_content = table.Column<string>(nullable: true),
                    project_image = table.Column<string>(nullable: true),
                    project_link = table.Column<string>(nullable: true),
                    project_price = table.Column<int>(nullable: true),
                    category_id = table.Column<int>(nullable: true),
                    service_id = table.Column<int>(nullable: true),
                    langguage_id = table.Column<int>(nullable: true),
                    project_hidden = table.Column<bool>(nullable: true),
                    position = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbproject", x => x.project_id);
                    table.ForeignKey(
                        name: "FK__tbproject__categ__5070F446",
                        column: x => x.category_id,
                        principalSchema: "dbo",
                        principalTable: "tbcategory",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__tbproject__servi__5165187F",
                        column: x => x.service_id,
                        principalSchema: "dbo",
                        principalTable: "tbservice",
                        principalColumn: "service_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbform_access",
                schema: "dbo",
                columns: table => new
                {
                    form_access_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    admin_email = table.Column<string>(maxLength: 100, nullable: true),
                    form_id = table.Column<int>(nullable: true),
                    form_access_type = table.Column<string>(nullable: true),
                    form_access_datecreate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbform_access", x => x.form_access_id);
                    table.ForeignKey(
                        name: "FK__tbform_ac__form___4D94879B",
                        column: x => x.form_id,
                        principalSchema: "dbo",
                        principalTable: "tbform",
                        principalColumn: "form_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbimageproject",
                schema: "dbo",
                columns: table => new
                {
                    image_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    image_link = table.Column<string>(nullable: true),
                    image_title = table.Column<string>(nullable: true),
                    image_summary = table.Column<string>(nullable: true),
                    project_id = table.Column<int>(nullable: true),
                    langguage_id = table.Column<int>(nullable: true),
                    position = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbimageproject", x => x.image_id);
                    table.ForeignKey(
                        name: "FK__tbimagepr__proje__4E88ABD4",
                        column: x => x.project_id,
                        principalSchema: "dbo",
                        principalTable: "tbproject",
                        principalColumn: "project_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbadmin_group_id",
                schema: "dbo",
                table: "tbadmin",
                column: "group_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbbaogialienquan_baogia_id",
                schema: "dbo",
                table: "tbbaogialienquan",
                column: "baogia_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbcategory_groupcate_id",
                schema: "dbo",
                table: "tbcategory",
                column: "groupcate_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbform_module_id",
                schema: "dbo",
                table: "tbform",
                column: "module_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbform_access_form_id",
                schema: "dbo",
                table: "tbform_access",
                column: "form_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbimageproject_project_id",
                schema: "dbo",
                table: "tbimageproject",
                column: "project_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbnews_newscate_id",
                schema: "dbo",
                table: "tbnews",
                column: "newscate_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbproject_category_id",
                schema: "dbo",
                table: "tbproject",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbproject_service_id",
                schema: "dbo",
                table: "tbproject",
                column: "service_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbseo_detail_seo_id",
                schema: "dbo",
                table: "tbseo_detail",
                column: "seo_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbservicedetail_service_id",
                schema: "dbo",
                table: "tbservicedetail",
                column: "service_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "abcs",
                schema: "db_owner");

            migrationBuilder.DropTable(
                name: "tbadmin",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbbaivietuser",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbbanggiachitietuser",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbbanggiagoidichvu",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbbanggiauser",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbbanneruser",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbbaogiachitiet",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbbaogialienquan",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbcontact",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbform_access",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbgiaproject",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbimageproject",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbintroduce",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tblanguage",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tblogo",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbnews",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbreviewscustome",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbseo_detail",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbservicedetail",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbslide",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbvideo",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbgroup",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbbaogia",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbform",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbproject",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbnewscate",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbseo",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbmodule",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbcategory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbservice",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tbgroupcate",
                schema: "dbo");
        }
    }
}
