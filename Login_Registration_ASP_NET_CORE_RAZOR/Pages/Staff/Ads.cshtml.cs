using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Login_Registration_ASP_NET_CORE_RAZOR.Model;

namespace Login_Registration_ASP_NET_CORE_RAZOR.Pages.Staff
{
    public class AdsModel : PageModel
    {
        [BindProperty(SupportsGet =true)]
        public Staffs staffs { get; set; }
        public string Msg;
        public void OnGet()             
        {

        }
        public IActionResult OnPost(Staffs _staffs)
        {
            _staffs = staffs;
            try
            {
                new DataLayer.DataAccessLayer().Insert(_staffs);
                Msg = "Success";
                return Page();
            }
            catch(Exception ex)
            {
                Msg = "Error Ocurred: "+ex.Message;
                return Page();
            }
        }

    }
}