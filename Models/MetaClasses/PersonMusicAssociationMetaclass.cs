using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicianApp.Models
{
    public partial class PersonMusicAssociation : IValidatableObject
    {
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield return ValidationResult.Success;
        }
    }
    public class PersonMusicAssociationMetaclass
    {
        [Display(Name = "First Name")]
        public string MemberName { get; set; }
        [Display(Name = "First Name")]
        public string lastName { get; set; }
        [Display(Name = "Band Name")]
        public string MusicAssociationName { get; set; }
    }
}
