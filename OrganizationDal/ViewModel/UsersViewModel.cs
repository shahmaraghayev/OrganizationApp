using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationDal.ViewModel
{
 public   class UsersViewModel
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("IStifadəçi Adı")]
        public string Name { get; set; }

        [DisplayName("Parol")]
        public string Password { get; set; }

        [DisplayName("Əməkdaşın adı")]
        public string PersonnelName { get; set; }

        [Browsable(false)]
        public int? Status { get; set; }
    }
}
