using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Unobtrusive_Ajax.Models;

namespace Razor_Unobtrusive_Ajax.Pages
{
    public class IndexModel : PageModel
    {
        [Required(ErrorMessage = "Enter your name")]
        [MinLength(2, ErrorMessage = "Write fullname")]
        public string Name { get; set; }

        public void OnGet()
        {
        }

        [HttpPost]
        public IActionResult OnPost(IndexModel model)
        {
            string str_oldname = string.Empty;
            try
            {
                str_oldname = HttpContext.Session.GetString("User");
            }
            catch (Exception ex)
            {

            }

            HttpContext.Session.SetString("User", model.Name);
            PersonModel person = new PersonModel
            {
                Name = model.Name,
                DateTime = DateTime.Now.ToString(),
                Oldname = str_oldname
            };

            return new JsonResult(person);
        }
    }
}