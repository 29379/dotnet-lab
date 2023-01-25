using lab13.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace lab13.ViewModels
{
    public class CartItemViewModel
    {
        [Required]
        public int ArticleId { get; set; }

        [Required]
        public Article Article { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity has to be greater than 0")]
        public int Quantity { get; set; }
    }
}

//  wyrzucic article, artykuly przeciagnac w zapytaniu do db na podstawie ilosci i ID, zeby ciasteczko było mniejsze
//  w  bazie ktos cos zaktualizuje, nie wplywa to na wartosci w ciasteczkach