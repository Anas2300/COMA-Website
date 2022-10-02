using System;
using System.Collections.Generic;

namespace MusicianApp.Models
{
    public partial class Person
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public DateTime? AssociationDate { get; set; }
        public string Email { get; set; }
        public int Request { get; set; }
        public bool? BalanceDue { get; set; }
        public int? Balance { get; set; }
        public int StatusId { get; set; }
    }
}
