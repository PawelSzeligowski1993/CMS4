using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CMS4.Migrations
{
    /// <inheritdoc />
    public partial class addUsersToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "advantages_list",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    text = table.Column<string>(type: "text", nullable: false),
                    additionaltext = table.Column<string>(name: "additional_text", type: "text", nullable: false),
                    iconurl = table.Column<string>(name: "icon_url", type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_advantages_list", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "services_list",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    text = table.Column<string>(type: "text", nullable: false),
                    additionaltext = table.Column<string>(name: "additional_text", type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_services_list", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "testimonials_list",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rating = table.Column<int>(type: "integer", nullable: false),
                    opinion = table.Column<string>(type: "text", nullable: false),
                    author = table.Column<string>(type: "text", nullable: false),
                    authordescription = table.Column<string>(name: "author_description", type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_testimonials_list", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fullname = table.Column<string>(name: "full_name", type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    cmsrole = table.Column<string>(name: "cms_role", type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    createddate = table.Column<DateTime>(name: "created_date", type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "about_us",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    sectionname = table.Column<string>(name: "section_name", type: "text", nullable: false),
                    sectiontype = table.Column<string>(name: "section_type", type: "text", nullable: false),
                    layoutposition = table.Column<int>(name: "layout_position", type: "integer", nullable: false),
                    lastmoddate = table.Column<DateTime>(name: "last_mod_date", type: "timestamp with time zone", nullable: false),
                    text = table.Column<string>(type: "text", nullable: false),
                    additionaltext = table.Column<string>(name: "additional_text", type: "text", nullable: false),
                    image1 = table.Column<string>(type: "text", nullable: false),
                    image2 = table.Column<string>(type: "text", nullable: false),
                    image3 = table.Column<string>(type: "text", nullable: false),
                    lastmoduserid = table.Column<int>(name: "last_mod_user_id", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_about_us", x => x.id);
                    table.ForeignKey(
                        name: "FK_about_us_users_last_mod_user_id",
                        column: x => x.lastmoduserid,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "advantages",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    sectionname = table.Column<string>(name: "section_name", type: "text", nullable: false),
                    sectiontype = table.Column<string>(name: "section_type", type: "text", nullable: false),
                    layoutposition = table.Column<int>(name: "layout_position", type: "integer", nullable: false),
                    lastmoddate = table.Column<DateTime>(name: "last_mod_date", type: "timestamp with time zone", nullable: false),
                    advantageslistid = table.Column<int>(name: "advantages_list_id", type: "integer", nullable: false),
                    lastmoduserid = table.Column<int>(name: "last_mod_user_id", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_advantages", x => x.id);
                    table.ForeignKey(
                        name: "FK_advantages_advantages_list_advantages_list_id",
                        column: x => x.advantageslistid,
                        principalTable: "advantages_list",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_advantages_users_last_mod_user_id",
                        column: x => x.lastmoduserid,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hero_banners",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    sectionname = table.Column<string>(name: "section_name", type: "text", nullable: false),
                    sectiontype = table.Column<string>(name: "section_type", type: "text", nullable: false),
                    layoutposition = table.Column<int>(name: "layout_position", type: "integer", nullable: false),
                    lastmoddate = table.Column<DateTime>(name: "last_mod_date", type: "timestamp with time zone", nullable: false),
                    text = table.Column<string>(type: "text", nullable: false),
                    additionaltext = table.Column<string>(name: "additional_text", type: "text", nullable: false),
                    backgroundimage = table.Column<string>(name: "background_image", type: "text", nullable: false),
                    lastmoduserid = table.Column<int>(name: "last_mod_user_id", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hero_banners", x => x.id);
                    table.ForeignKey(
                        name: "FK_hero_banners_users_last_mod_user_id",
                        column: x => x.lastmoduserid,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "numbers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    sectionname = table.Column<string>(name: "section_name", type: "text", nullable: false),
                    sectiontype = table.Column<string>(name: "section_type", type: "text", nullable: false),
                    layoutposition = table.Column<int>(name: "layout_position", type: "integer", nullable: false),
                    lastmoddate = table.Column<DateTime>(name: "last_mod_date", type: "timestamp with time zone", nullable: false),
                    text = table.Column<string>(type: "text", nullable: false),
                    value1 = table.Column<string>(type: "text", nullable: false),
                    description1 = table.Column<string>(type: "text", nullable: false),
                    value2 = table.Column<string>(type: "text", nullable: false),
                    description2 = table.Column<string>(type: "text", nullable: false),
                    lastmoduserid = table.Column<int>(name: "last_mod_user_id", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_numbers", x => x.id);
                    table.ForeignKey(
                        name: "FK_numbers_users_last_mod_user_id",
                        column: x => x.lastmoduserid,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "services",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    sectionname = table.Column<string>(name: "section_name", type: "text", nullable: false),
                    sectiontype = table.Column<string>(name: "section_type", type: "text", nullable: false),
                    layoutposition = table.Column<int>(name: "layout_position", type: "integer", nullable: false),
                    lastmoddate = table.Column<DateTime>(name: "last_mod_date", type: "timestamp with time zone", nullable: false),
                    text = table.Column<string>(type: "text", nullable: false),
                    lastmoduserid = table.Column<int>(name: "last_mod_user_id", type: "integer", nullable: false),
                    serviceslistid = table.Column<int>(name: "services_list_id", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_services", x => x.id);
                    table.ForeignKey(
                        name: "FK_services_services_list_services_list_id",
                        column: x => x.serviceslistid,
                        principalTable: "services_list",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_services_users_last_mod_user_id",
                        column: x => x.lastmoduserid,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "testimonials",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    sectionname = table.Column<string>(name: "section_name", type: "text", nullable: false),
                    sectiontype = table.Column<string>(name: "section_type", type: "text", nullable: false),
                    layoutposition = table.Column<int>(name: "layout_position", type: "integer", nullable: false),
                    lastmoddate = table.Column<DateTime>(name: "last_mod_date", type: "timestamp with time zone", nullable: false),
                    text = table.Column<string>(type: "text", nullable: false),
                    additionaltext = table.Column<string>(name: "additional_text", type: "text", nullable: false),
                    testimonialslistid = table.Column<int>(name: "testimonials_list_id", type: "integer", nullable: false),
                    lastmoduserid = table.Column<int>(name: "last_mod_user_id", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_testimonials", x => x.id);
                    table.ForeignKey(
                        name: "FK_testimonials_testimonials_list_testimonials_list_id",
                        column: x => x.testimonialslistid,
                        principalTable: "testimonials_list",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_testimonials_users_last_mod_user_id",
                        column: x => x.lastmoduserid,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "work_with_us",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    sectionname = table.Column<string>(name: "section_name", type: "text", nullable: false),
                    sectiontype = table.Column<string>(name: "section_type", type: "text", nullable: false),
                    layoutposition = table.Column<int>(name: "layout_position", type: "integer", nullable: false),
                    lastmoddate = table.Column<DateTime>(name: "last_mod_date", type: "timestamp with time zone", nullable: false),
                    text = table.Column<string>(type: "text", nullable: false),
                    additionaltext = table.Column<string>(name: "additional_text", type: "text", nullable: false),
                    backgroundimage = table.Column<string>(name: "background_image", type: "text", nullable: false),
                    lastmoduserid = table.Column<int>(name: "last_mod_user_id", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_work_with_us", x => x.id);
                    table.ForeignKey(
                        name: "FK_work_with_us_users_last_mod_user_id",
                        column: x => x.lastmoduserid,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_about_us_last_mod_user_id",
                table: "about_us",
                column: "last_mod_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_advantages_advantages_list_id",
                table: "advantages",
                column: "advantages_list_id");

            migrationBuilder.CreateIndex(
                name: "IX_advantages_last_mod_user_id",
                table: "advantages",
                column: "last_mod_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_hero_banners_last_mod_user_id",
                table: "hero_banners",
                column: "last_mod_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_numbers_last_mod_user_id",
                table: "numbers",
                column: "last_mod_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_services_last_mod_user_id",
                table: "services",
                column: "last_mod_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_services_services_list_id",
                table: "services",
                column: "services_list_id");

            migrationBuilder.CreateIndex(
                name: "IX_testimonials_last_mod_user_id",
                table: "testimonials",
                column: "last_mod_user_id");

            migrationBuilder.CreateIndex(
                name: "IX_testimonials_testimonials_list_id",
                table: "testimonials",
                column: "testimonials_list_id");

            migrationBuilder.CreateIndex(
                name: "IX_work_with_us_last_mod_user_id",
                table: "work_with_us",
                column: "last_mod_user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "about_us");

            migrationBuilder.DropTable(
                name: "advantages");

            migrationBuilder.DropTable(
                name: "hero_banners");

            migrationBuilder.DropTable(
                name: "numbers");

            migrationBuilder.DropTable(
                name: "services");

            migrationBuilder.DropTable(
                name: "testimonials");

            migrationBuilder.DropTable(
                name: "work_with_us");

            migrationBuilder.DropTable(
                name: "advantages_list");

            migrationBuilder.DropTable(
                name: "services_list");

            migrationBuilder.DropTable(
                name: "testimonials_list");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
