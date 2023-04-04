using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Razor_Unobtrusive_Ajax.Models
{
    public class PersonModel
    {
        ///<summary>
        /// Gets or sets Name.
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// Gets or sets DateTime.
        ///</summary>
        public string DateTime { get; set; }

        public string Oldname { get; set; }
    }


    public class PersonRequestModel
    {
        [Required(ErrorMessage ="Enter your name")]
        [MinLength(1,ErrorMessage = "Write fullname")]
        public string Name { get; set; }        
    }
}
