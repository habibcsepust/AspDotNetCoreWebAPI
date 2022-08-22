using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreWebAPI.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title can not null")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description can not null")]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
