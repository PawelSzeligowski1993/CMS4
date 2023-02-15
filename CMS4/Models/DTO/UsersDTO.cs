using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.DTO
{
    public class UsersDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string full_name { get; set; }
        public string email { get; set; }
        public string cms_role { get; set; }
        public string password { get; set; }
        public DateTime created_date { get; set; }

        //[ForeignKey("hero_banners")]
        //public int hero_banners_id { get; set; }

        //[ForeignKey("services")]
        //public int services_id { get; set; }

        //[ForeignKey("about_us")]
        //public int about_us_id { get; set; }

        //[ForeignKey("numbers")]
        //public int numbers_id { get; set; }

        //[ForeignKey("work_with_us")]
        //public int work_with_us_id { get; set; }

        //[ForeignKey("testimonials")]
        //public int testimonials_id { get; set; }

        //[ForeignKey("advantages")]
        //public int advantages_id { get; set; }

    }
}

