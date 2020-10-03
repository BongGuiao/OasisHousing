using System;
using System.Collections.Generic;
using System.Text;

namespace OasisHousing.Domain.Entities
{
    public class Tenant
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
    }
}
