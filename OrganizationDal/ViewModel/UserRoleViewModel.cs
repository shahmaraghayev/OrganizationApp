using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationDal.ViewModel
{
  public  class UserRoleViewModel
    {

        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("İstifadəçi ")]
        public string UserName { get; set; }

        [DisplayName("Səlahiyyət")]
        public string RoleName { get; set; }
    }
}
