using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AquilaSoftware.Pages
{
    public class EntryMenuScreenModel : PageModel
    {
        private readonly ILogger<EntryMenuScreenModel> _logger;

        public EntryMenuScreenModel(ILogger<EntryMenuScreenModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {

        }
    }
}