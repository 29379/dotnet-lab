using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab12.ViewModels
{
    public class ArticleCreateViewModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "The name is too short - min length is 2")]
        [MaxLength(255, ErrorMessage = " The name is too long - max length is 255")]
        public string Name { get; set; }

        [Required]
        [Range(0.0, Double.MaxValue, ErrorMessage = "The value has to be bigger than 0")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        public int? CategoryId { get; set; }

        [NotMapped]
        public IFormFile? FFile { get; set; }
    }
}