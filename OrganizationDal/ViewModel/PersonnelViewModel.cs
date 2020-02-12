using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationDal.ViewModel
{
   public class PersonnelViewModel
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("Ad")]
        public string Name { get; set; }

        [DisplayName("Soyad")]
        public string Surname { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName(" departamentin adı")]
        public string Departamentname { get; set; }

        [DisplayName("Təçkilatın adı")]
        public string OrganizationName { get; set; }

        [DisplayName("Status")]
        public int? Status { get; set; }




        
    }
}
