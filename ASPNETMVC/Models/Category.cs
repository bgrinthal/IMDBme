using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPNETMVC.Models
{
    public class Category
    {
       // [Key]
        //public int Id { get; set; }
        //[Required]
        //public string Name { get; set; }
        // To show the table name as a different name
        //[DisplayName("Display Order")]
        //[Required]
        //[Range(1,int.MaxValue,ErrorMessage = "Display order must be greater than 0")]
        //public int DisplayOrder { get; set; } 

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        // To show the table name as a different name
        [Required]
        [Range(1, 10, ErrorMessage = "Display order must be greater than 0")]
        public int Rating { get; set; }
    }
}
