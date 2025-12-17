using System.ComponentModel.DataAnnotations;

namespace WebShopAppp.Models.Brand
{
    public class CategoryPairVM
    {
        public int Id { get; set; }

        [Display(Name = "Category")]
        public string Name { get; set; } = null!;
    }
}
