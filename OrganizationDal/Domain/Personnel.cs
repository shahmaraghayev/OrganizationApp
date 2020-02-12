﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationDal.Domain
{
  public   class Personnel
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public int? Status { get; set; }

        public int? OrganizationId { get; set; }

        public int? DepartmentId { get; set; }

    }
}
