using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace suave.Views.Shared
{
    public class _LanchesResumo : PageModel
    {
        private readonly ILogger<_LanchesResumo> _logger;

        public _LanchesResumo(ILogger<_LanchesResumo> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}