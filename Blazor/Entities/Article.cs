﻿using System.ComponentModel.DataAnnotations;

namespace Blazor.Entities
{
    public class Article
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
    }
}
