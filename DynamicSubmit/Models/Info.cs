using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
namespace DynamicSubmit.Models
{
    public class Info
    {    
        [Display(Name = "Enter your first name:")]
        public string name { get; set; }

        [Display(Name = "Enter your last name:")]
        public string family  { get; set; }

        [Display(Name = "Description:")]
        public string description { get; set; }

        [Display(Name = "Date of Your Birth:")]
        public string DOF { get; set; }
        

    }
}
