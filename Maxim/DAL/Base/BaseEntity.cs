using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Create { get; set; }
        public DateTime? Update { get; set; }
    }
}
