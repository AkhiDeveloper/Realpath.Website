using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Realpath.NewWebSite.Data;
using Realpath.NewWebSite.Data.Models;

namespace Realpath.NewWebSite.Pages.Contactus
{
    public class DetailsModel : PageModel
    {
        private readonly Realpath.NewWebSite.Data.RealpathNewWebSiteContext _context;

        public DetailsModel(Realpath.NewWebSite.Data.RealpathNewWebSiteContext context)
        {
            _context = context;
        }

      public CompanyInfo CompanyInfo { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CompanyInfo == null)
            {
                return NotFound();
            }

            var companyinfo = await _context.CompanyInfo.FirstOrDefaultAsync(m => m.id == id);
            if (companyinfo == null)
            {
                return NotFound();
            }
            else 
            {
                CompanyInfo = companyinfo;
            }
            return Page();
        }
    }
}
