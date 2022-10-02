using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicianApp.Models
{
    [ModelMetadataType(typeof(InstrumentMetaclass))]
    public partial class Instrument : IValidatableObject
    {
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield return ValidationResult.Success;
        }
    }
    public class InstrumentMetaclass
    {
        [Display(Name = "Instrument Name")]
        public string InstrumentName { get; set; }
    }
}
