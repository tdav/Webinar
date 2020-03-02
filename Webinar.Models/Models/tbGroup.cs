﻿using System.Collections.Generic;

namespace Webinar.Models
{
    public class tbGroup : BaseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<tbUser> Users { get; set; }
    }
}
