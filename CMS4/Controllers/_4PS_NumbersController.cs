using Microsoft.AspNetCore.Mvc;
using Npgsql;
using System.Data;
using WebApplication1.Models.DTO;

namespace WebApplication1.Controllers.SectionsController
{
    [Route("api/[controller]")]
    [ApiController]
    public class _4PS_NumbersController : ControllerBase
    {

        private readonly IConfiguration _configuration;
        public _4PS_NumbersController(IConfiguration configuration)
        {
            _configuration = configuration;
        }




        //------------------------------------------- GET by name numbers ------------------------------------------------
        //-------------------Get all numbers -------------------
        [HttpGet]
        public JsonResult Get_numbers()
        {
            //string name = "numbers";

            string query = @"
                select id as ""id"",
                        section_name as ""section_name"",
                        section_type as ""section_type"",
                        layout_position as ""layout_position"",
                        last_mod_date as ""last_mod_date"",
                        text as ""text"",
                        additional_text as ""additional_text"",
                        image1 as ""image1"",
                        image2 as ""image2"",
                        image3 as ""image3"",
                        last_mod_user_id as ""last_mod_user_id""   
                from numbers
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


        //------------------- Get numbers by title -------------------

        [HttpGet("{section_name}")]
        public JsonResult GetNumbersByTitle(string section_name)
        {
            //string name = "numbers";
            string query = @"
                select id as ""id"",
                        section_name as ""section_name"",
                        section_type as ""section_type"",
                        layout_position as ""layout_position"",
                        last_mod_date as ""last_mod_date"",
                        text as ""text"",
                        additional_text as ""additional_text"",
                        image1 as ""image1"",
                        image2 as ""image2"",
                        image3 as ""image3"",
                        last_mod_user_id as ""last_mod_user_id""    
                from numbers
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

        ////------------------------------------------- POST by name numbers ------------------------------------------------
        [HttpPost]
        public JsonResult PostNumbers(DB4_NumbersDTO numbers)
        {
            int id = 0;
            string query = @"
                insert into page_Sections
                (id,section_name,section_type,layout_position,last_mod_date,text,value1,description1,value2,description2,last_mod_user_id)
                values 
                (@id,@section_name,@section_type,@layout_position,@last_mod_date,@text,@value1,@description1,@value2,@description2,@last_mod_user_id)
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("SampleDBConnection");
            NpgsqlDataReader myReader;
            using (NpgsqlConnection myCon = new NpgsqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (NpgsqlCommand myCommand = new NpgsqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@id", numbers.id);
                    myCommand.Parameters.AddWithValue("@section_name", numbers.section_name);
                    myCommand.Parameters.AddWithValue("@section_type", numbers.section_type);
                    myCommand.Parameters.AddWithValue("@layout_position", numbers.layout_position);
                    myCommand.Parameters.AddWithValue("@last_mod_date", numbers.last_mod_date);
                    myCommand.Parameters.AddWithValue("@text", numbers.text);
                    myCommand.Parameters.AddWithValue("@value1", numbers.value1);
                    myCommand.Parameters.AddWithValue("@description1", numbers.description1);
                    myCommand.Parameters.AddWithValue("@value2", numbers.value2);
                    myCommand.Parameters.AddWithValue("@description2", numbers.description2);
                    myCommand.Parameters.AddWithValue("@last_mod_user_id", numbers.last_mod_user_id);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();

                }
            }

            return new JsonResult("New numbers Added Successfully");
        }


        ////------------------------------------------- PUT (update) IN numbers ------------------------------------------------

        [HttpPut]
        public JsonResult PutInNumbers(DB4_NumbersDTO numbers)
        {
            string query = @"
                update numbers
                set id = @id,
                section_name = @section_name,
                section_type = @section_type,
                layout_position = @layout_position,
                last_mod_date = @last_mod_date,
                text = @text,
                value1 = @value1,
                description1 = @description1,
                value2 = @value2,
                description2 = @description2,
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
                    myCommand.Parameters.AddWithValue("@id", numbers.id);
                    myCommand.Parameters.AddWithValue("@section_name", numbers.section_name);
                    myCommand.Parameters.AddWithValue("@section_type", numbers.section_type);
                    myCommand.Parameters.AddWithValue("@layout_position", numbers.layout_position);
                    myCommand.Parameters.AddWithValue("@last_mod_date", numbers.last_mod_date);
                    myCommand.Parameters.AddWithValue("@text", numbers.text);
                    myCommand.Parameters.AddWithValue("@value1", numbers.value1);
                    myCommand.Parameters.AddWithValue("@description1", numbers.description1);
                    myCommand.Parameters.AddWithValue("@value2", numbers.value2);
                    myCommand.Parameters.AddWithValue("@description2", numbers.description2);
                    myCommand.Parameters.AddWithValue("@last_mod_user_id", numbers.last_mod_user_id);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();

                }
            }

            return new JsonResult("numbers Updated Successfully");
        }


        ////---------------------------------------------- Delete by Id and name(Baner) ----------------------------------------------
        [HttpDelete("{id}")]
        public JsonResult DeleteNumbers(int id)
        {
            string query = @"
                delete from numbers
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
            return new JsonResult("Numbers Deleted Successfully");
        }


    }
}



