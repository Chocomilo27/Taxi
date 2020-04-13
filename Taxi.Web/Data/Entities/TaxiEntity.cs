using System.ComponentModel.DataAnnotations;

namespace Taxi.Web.Data.Entities
{
    public class TaxiEntity
    {
        public int Id { get; set; }


        [StringLength(6, MinimumLength = 6, ErrorMessage = "The {0} field must have {1} characters.")] //1 refers to the first condition (6)
        [Required(ErrorMessage = "The field {0} is mandatory.")] //The "0" refers to the name of field.
        public string Plaque { get; set; }

    }
}
