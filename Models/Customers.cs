﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace juandm_Final413.Models
{
    public partial class Customers
    {
        [Required]
        public long CustomerId { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public string CustStreetAddress { get; set; }
        public string CustCity { get; set; }
        public string CustState { get; set; }
        public string CustZipCode { get; set; }
        public string CustPhoneNumber { get; set; }
    }
}
