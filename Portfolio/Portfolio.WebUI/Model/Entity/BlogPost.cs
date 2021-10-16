using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.WebUI.Model.Entity
{
    public class BlogPost:BaseEntity
    {
        public string Title { get; set; }

        public string BlogType { get; set; }

        public string Body { get; set; }

        public string ImagePati { get; set; }

        public string Description { get; set; }

        public string ShopDescription { get; set; }

        public DateTime? PublishedDate { get; set; }
    }
}
