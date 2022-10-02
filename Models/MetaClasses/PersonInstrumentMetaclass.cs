using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicianApp.Models
{
    [ModelMetadataType(typeof(PersonInstrumentMetaclass))]
    public partial class PersonInstrument : IValidatableObject
    {
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            
            yield return ValidationResult.Success;
        }
    }
    public class PersonInstrumentMetaclass
    {
        [Display(Name = "First Name")]
        public string memberName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Display(Name = "Instrument Name")]
        public string instrumentName { get; set; }
    }
}
