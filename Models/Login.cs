using System.ComponentModel.DataAnnotations;

namespace Site2.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string nome { get; set; }

        [Required]
        public string senha { get; set; }
    }

}
