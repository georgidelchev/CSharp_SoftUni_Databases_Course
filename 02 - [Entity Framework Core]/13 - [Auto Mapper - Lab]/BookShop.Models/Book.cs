﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using BookShop.Models.Enums;

namespace BookShop.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public int Copies { get; set; }

        public decimal Price { get; set; }

        public EditionType EditionType { get; set; }

        public AgeRestriction AgeRestriction { get; set; }

        public int AuthorId { get; set; }

        [JsonIgnore]
        public Author Author { get; set; }

        [JsonIgnore]
        public ICollection<BookCategory> BookCategories { get; set; }
            = new HashSet<BookCategory>();
    }
}