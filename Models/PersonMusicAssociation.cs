using System;
using System.Collections.Generic;

namespace MusicianApp.Models
{
    public partial class PersonMusicAssociation
    {
        public int PersonMusicAssociationId { get; set; }
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string lastName { get; set; }
        public string MusicAssociationName { get; set; }
    }
}
