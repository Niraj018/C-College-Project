
using onine_Shopping.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace onine_Shopping.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
       [ StringLength(maximumLength:20,ErrorMessage = "Characters cannot be greater than 20")]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string Title { get; set; }
        
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        public int Price { get; set; }

        [DisplayName("Category Name")]

        public int CategoryID { get; set; }

        public virtual Category? Category { get; set; }
    }
}
