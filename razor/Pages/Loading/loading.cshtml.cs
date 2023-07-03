using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SlimeTAP.Pages.Loading
{
    public class loading : PageModel
    {
        private readonly ILogger<loading> _logger;

        public loading(ILogger<loading> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}