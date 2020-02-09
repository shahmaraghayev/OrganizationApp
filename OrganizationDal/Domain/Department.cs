using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationDal.Domain
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? TopId { get; set; }

        public int? Status { get; set; }

        public int? OrganizationId { get; set; }

    }

}
