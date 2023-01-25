﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab10.Models
{
	public class Category
	{
		public int Id { get; set; }

        [MinLength(2, ErrorMessage = "The name is too short - min length is 2")]
        [MaxLength(255, ErrorMessage = " The name is too long - max length is 255")]
        [Required]
		public string Name { get; set; }

		public ICollection<Article> Articles { get; set; }

		public Category() { }

		public Category(int id, string name)
		{
			Id = id;
			Name = name;
		}
	}
}