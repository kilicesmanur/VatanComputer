﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vatan.Models.ORM.Entities
{
    public class Category : Base
    {
      
        public string CategoryName { get; set; }
        public int TopCategoryID { get; set; }
        public List<Product> Products  { get; set; }




    }
}
