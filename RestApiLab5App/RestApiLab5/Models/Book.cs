using System.ComponentModel.DataAnnotations;

namespace RestApiLab5.Models
{

    //Need to create Folder Models and then Add -> New Item -> Class
    public class Book
    {
        
        public Guid Id { get; set; }

        public string? Title { get; set; }

        [Range(0,100)]
        public decimal Price { get; set; }


    }
}
