using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bussiness_Directory.Models
{
    public class Bussiness
    {
        [Display(Name = "Business ID")]
        public virtual string bussinessId { get; set; }
        [Display(Name = "Business Name")]
        public virtual string Bussname { get; set; }
        [Display(Name = "Business Location")]
        public virtual string location { get; set; }
        [Display(Name = "Business Contact")]
        public virtual string BussPhoneNumber { get; set; }
        [Display(Name = "Business LOGO")]
        public virtual string Busslogo { get; set; }
        [Display(Name = "Business Description")]
        public virtual string discription { get; set; }

    }
}