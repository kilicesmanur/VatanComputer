using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vatan.Areas.Admin.Models.VM
{
    public class CategoryCheckVM
    {
        public int categoryid { get; set; }
        public bool IsChecked { get; set; }
        public string Name { get; set; }
    }
}
