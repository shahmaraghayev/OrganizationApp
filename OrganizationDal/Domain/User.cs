using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationDal.Domain
{
  public  class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }

        public int? Status { get; set; }

        public int? PersonnelId { get; set; }

      
    }
}
