using System.ComponentModel.DataAnnotations;


namespace AbbyWeb.Models
{
    public class FoodType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
