using System;
using System.Collections.Generic;

namespace MusicianApp.Models
{
    public partial class PersonInstrument
    {
        public int PersonInstrumentId { get; set; }
        public int PersonId { get; set; }
        public int InstrumentId { get; set; }
        public string memberName { get; set; }
        public string lastName { get; set; }
        public string instrumentName { get; set; }


    }
}
