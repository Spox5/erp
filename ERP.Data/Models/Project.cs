using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Data.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Customer { get; set; }
    }
}
