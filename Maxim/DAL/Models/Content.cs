using DAL.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Content : BaseEntity
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ImageUrl { get; set; }
    }
}
