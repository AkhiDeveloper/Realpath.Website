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
    public class DeleteModel : PageModel
    {
        private readonly Realpath.NewWebSite.Data.RealpathNewWebSiteContext _context;

        public DeleteModel(Realpath.NewWebSite.Data.RealpathNewWebSiteContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.CompanyInfo == null)
            {
                return NotFound();
            }
            var companyinfo = await _context.CompanyInfo.FindAsync(id);

            if (companyinfo != null)
            {
                CompanyInfo = companyinfo;
                _context.CompanyInfo.Remove(CompanyInfo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
