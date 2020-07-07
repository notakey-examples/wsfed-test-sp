using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authentication.WsFederation;

namespace WSFedTest.Pages
{
    public class LogoutAllModel : PageModel
    {
        private readonly ILogger<LogoutAllModel> _logger;

        public LogoutAllModel(ILogger<LogoutAllModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var adfsPrefix = Environment.GetEnvironmentVariable("ADFS_URL_PREFIX");
            Response.Redirect(String.Format("{0}/adfs/ls/?wa=wsignout1.0", adfsPrefix));
        }
    }
}
