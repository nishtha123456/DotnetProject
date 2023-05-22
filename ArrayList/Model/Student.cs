using System.ComponentModel.DataAnnotations;

namespace ArrayList.Model
{
    public class Student
    {
        [Key]
        public int Id{ get; set; }
        [Required]
        public string Name{ get; set; }
   
    }
}
