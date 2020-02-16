using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationDal.ViewModel
{
  public   class OrganizationViewModel
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("Ad")]
        public string Name { get; set; }

        [Browsable(false)]
        public int? Status { get; set; }

    }
}
