using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalUniversityDebate.Pages
{
    public class HistoryModel : PageModel
    {
        private readonly ILogger<HistoryModel> _logger;

        public HistoryModel(ILogger<HistoryModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}