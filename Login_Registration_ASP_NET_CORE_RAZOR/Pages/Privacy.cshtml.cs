using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Login_Registration_ASP_NET_CORE_RAZOR.Pages
{
    [Authorize]///the page is no longer accessible when not login
    public class PrivacyModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}