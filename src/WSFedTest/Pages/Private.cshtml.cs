using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WSFedTest.Pages
{
    public class PrivateModel : PageModel
    {
        private readonly ILogger<PrivateModel> _logger;

        public PrivateModel(ILogger<PrivateModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
