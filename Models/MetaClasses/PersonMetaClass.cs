using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicianApp.Models
{
    [ModelMetadataType(typeof(PersonMetaClass))]
    public partial class Person : IValidatableObject
    {
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // yield return new ValidationResult("Validation error");

            

            yield return ValidationResult.Success;
        }
    }

    public class PersonMetaClass
    {
        public int MemberId { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Password { get; set; }
        [Display(Name = "Join in Date")]
        public DateTime? AssociationDate { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public int Request { get; set; }
        [Display(Name = "Balance Owing (True or False)")]
        public bool? BalanceDue { get; set; }
        public int? Balance { get; set; }
        public int StatusId { get; set; }
    }



}
