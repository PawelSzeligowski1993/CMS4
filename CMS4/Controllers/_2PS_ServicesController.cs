using Microsoft.AspNetCore.Mvc;
using Npgsql;
using System.Data;
using WebApplication1.Models.DTO;

namespace CMS_Projekt_API.Controllers
{
    //------------------------------------------- GET ------------------------------------------------
    //-------------------Get all-------------------
    [Route("api/[controller]")]
    [ApiController]
    public class _2PS_ServicesController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public _2PS_ServicesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //------------------------------------------- GET by name hero_banners ------------------------------------------------
        //-------------------Get all hero_banners -------------------
        [HttpGet]
        public JsonResult Get_Hero_Banners()
        {
            //string name = "hero_banners";

            string query = @"
                select 
                        u.full_name as ""u.full_name"",
                        hb.id as ""hb.id"",
                        section_name as ""section_name"",
                        section_type as ""section_type"",
                        layout_position as ""layout_position"",
                        last_mod_date as ""last_mod_date"",
                        text as ""text"",
                        services_list_id
                        last_mod_user_id as ""last_mod_user_id""   
                 from hero_banners as hb
                 inner join  users as u on u.id = hb.last_mod_user_id
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("SampleDBConnection");
            NpgsqlDataReader myReader;
            using (NpgsqlConnection myCon = new NpgsqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (NpgsqlCommand myCommand = new NpgsqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();

                }
            }

            return new JsonResult(table);
        }


        //------------------- Get hero_banners by title -------------------

        [HttpGet("{section_name}")]
        public JsonResult GetHero_BannersByTitle(string section_name)
        {
            //string name = "hero_banners";
            string query = @"
                select id as ""id"",
                        section_name as ""section_name"",
                        section_type as ""section_type"",
                        layout_position as ""layout_position"",
                        last_mod_date as ""last_mod_date"",
                        text as ""text"",
                        additional_text as ""additional_text"",
                        background_image as ""background_image"",
                        last_mod_user_id as ""last_mod_user_id""   
                from hero_banners
                where (section_name=@section_name)
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("SampleDBConnection");
            NpgsqlDataReader myReader;
            using (NpgsqlConnection myCon = new NpgsqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (NpgsqlCommand myCommand = new NpgsqlCommand(query, myCon))
                {

                    myCommand.Parameters.AddWithValue("@section_name", section_name);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();

                }
            }

            return new JsonResult(table);
        }

        ////------------------------------------------- POST by name hero_banners ------------------------------------------------
        [HttpPost]
        public JsonResult hero_banners(DB1_HeroBannerDTO hero_banners)
        {
            int id = 0;
            string query = @"
                insert into page_Sections
                (id,section_name,section_type,layout_position,last_mod_date,text,additional_text,background_image,last_mod_user_id)
                values 
                (@id,@section_name,@section_type,@layout_position,@last_mod_date,@text,@additional_text,@background_image,@last_mod_user_id)
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("SampleDBConnection");
            NpgsqlDataReader myReader;
            using (NpgsqlConnection myCon = new NpgsqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (NpgsqlCommand myCommand = new NpgsqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@id", hero_banners.id);
                    myCommand.Parameters.AddWithValue("@section_name", hero_banners.section_name);
                    myCommand.Parameters.AddWithValue("@section_type", hero_banners.section_type);
                    myCommand.Parameters.AddWithValue("@layout_position", hero_banners.layout_position);
                    myCommand.Parameters.AddWithValue("@last_mod_date", hero_banners.last_mod_date);
                    myCommand.Parameters.AddWithValue("@text", hero_banners.text);
                    myCommand.Parameters.AddWithValue("@additional_text", hero_banners.additional_text);
                    myCommand.Parameters.AddWithValue("@background_image", hero_banners.background_image);
                    myCommand.Parameters.AddWithValue("@last_mod_user_id", hero_banners.last_mod_user_id);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();

                }
            }

            return new JsonResult("New hero_banners Added Successfully");
        }


        ////------------------------------------------- PUT (update) IN hero_banners ------------------------------------------------

        [HttpPut]
        public JsonResult PutInHero_Banners(DB1_HeroBannerDTO hero_banners)
        {
            string query = @"
                update hero_banners
                set id = @id,
                section_name = @section_name,
                section_type = @section_type,
                layout_position = @layout_position,
                last_mod_date = @last_mod_date,
                text = @text,
                additional_text = @additional_text,
                background_image = @background_image,
                last_mod_user_id = @last_mod_user_id
                where (id = @id) 
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("SampleDBConnection");
            NpgsqlDataReader myReader;
            using (NpgsqlConnection myCon = new NpgsqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (NpgsqlCommand myCommand = new NpgsqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@id", hero_banners.id);
                    myCommand.Parameters.AddWithValue("@section_name", hero_banners.section_name);
                    myCommand.Parameters.AddWithValue("@section_type", hero_banners.section_type);
                    myCommand.Parameters.AddWithValue("@layout_position", hero_banners.layout_position);
                    myCommand.Parameters.AddWithValue("@last_mod_date", hero_banners.last_mod_date);
                    myCommand.Parameters.AddWithValue("@text", hero_banners.text);
                    myCommand.Parameters.AddWithValue("@additional_text", hero_banners.additional_text);
                    myCommand.Parameters.AddWithValue("@background_image", hero_banners.background_image);
                    myCommand.Parameters.AddWithValue("@last_mod_user_id", hero_banners.last_mod_user_id);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();

                }
            }

            return new JsonResult("Hero_banners Updated Successfully");
        }


        ////---------------------------------------------- Delete by Id and name(Baner) ----------------------------------------------
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = @"
                delete from hero_banners
                where (id=@id );
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("SampleDBConnection");
            NpgsqlDataReader myReader;
            using (NpgsqlConnection myCon = new NpgsqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (NpgsqlCommand myCommand = new NpgsqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@id", id);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();

                }
            }
            return new JsonResult("Hero_banners Deleted Successfully");
        }


    }
}
