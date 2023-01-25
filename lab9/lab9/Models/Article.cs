using System;
using System.ComponentModel.DataAnnotations;

namespace lab9.Models
{
    public enum Category { Books, Music, Film, Games, Food, Other }
    public class Article
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "The name is too short")]
        [MaxLength(255, ErrorMessage = "The name is too long")]
        public string Name { get; set; }
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ExpirationDate { get; set; }
        
        public Category Category { get; set; }

        public Article() { }

        public Article(int id, string name, decimal price, Nullable<DateTime> expirationDate, Category category)
        {
            Id = id;
            Name = name;
            Price = Math.Round(price, 2, MidpointRounding.AwayFromZero);
            ExpirationDate = expirationDate;
            Category = category;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
