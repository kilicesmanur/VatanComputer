﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vatan.Models.ORM.Entities
{
    public class Picture : Base
    {
        
        public string Path { get; set; }
        public int ProductId { get; set; }
        [ForeignKey ("ProductId")]
        public Product Product { get; set; }
    }
}
