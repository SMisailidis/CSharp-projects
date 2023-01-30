using System.ComponentModel.DataAnnotations;

namespace RestApiLab5.Models
{
    public class CreateOrUpdateBookSchema
    {
        public string? Title { get; set; }

        [Range(0,100)]
        public decimal Price { get; set; }
    }
}
