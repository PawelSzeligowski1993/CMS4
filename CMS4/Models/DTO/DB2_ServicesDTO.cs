﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.DTO
{
    public class DB2_ServicesDTO
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        [Required]
        public string section_name { get; set; }
        public string section_type { get; set; }
        public int layout_position { get; set; }
        public DateTime last_mod_date { get; set; }
        public string text { get; set; }

        [ForeignKey("users")]
        public int last_mod_user_id { get; set; }
        public UsersDTO users { get; set; }

        [ForeignKey("services_list")]
        public int services_list_id { get; set; }
        public DB2_ServicesListDTO services_list { get; set; }

    }
}
