using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50,ErrorMessage = "Email should be less than 51")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Password should be Greater than 8")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
