﻿using System;

namespace OrganizationDal.Domain
{
    public class User1
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }

        public bool IsActive { get; set; }
    }
}
