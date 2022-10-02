using System;
using System.Collections.Generic;

namespace MusicianApp.Models
{
    public partial class Phone
    {
        public int PhoneNumber { get; set; }
        public string PhoneType { get; set; }
        public int MemberId { get; set; }
    }
}
