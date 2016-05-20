using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularSample.Models
{
    public class Articels
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Body { get; set; }
        public DateTime DatePublished { get; set; }
        public int CategoryId { get; set; }
    }
}