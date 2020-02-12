using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationDal.ViewModel
{
 public   class RolesViewModel
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("Ad")]
        public string Name { get; set; }
    }
}
