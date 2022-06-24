using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Back.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Image { get; set; }
        public string Founder { get; set; }
        public string Comment { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
