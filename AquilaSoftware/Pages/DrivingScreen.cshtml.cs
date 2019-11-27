using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AquilaSoftware.Pages
{
   
    public class DrivingScreenModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public DrivingScreenModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}