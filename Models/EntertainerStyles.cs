using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace juandm_Final413.Models
{
    public partial class EntertainerStyles
    {
        [Required]
        public long? EntertainerId { get; set; }
        public long? StyleId { get; set; }
        public long? StyleStrength { get; set; }
    }
}
