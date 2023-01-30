using System.ComponentModel.DataAnnotations;

namespace RestApiLab5.Models
{
    public class Book
    {
        
        public Guid Id { get; set; }

        public string? Title { get; set; }

        [Range(0,100)]
        public decimal Price { get; set; }


    }
}
