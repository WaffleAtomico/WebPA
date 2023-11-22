using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebVirus.Views.IndexForUser.Almacenist
{
    public class AlmacenistIndex : PageModel
    {
        private readonly ILogger<AlmacenistIndex> _logger;

        public AlmacenistIndex(ILogger<AlmacenistIndex> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}