using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Realpath.NewWebSite.Data;
using Realpath.NewWebSite.Data.Models;

namespace Realpath.NewWebSite.Pages.Contactus
{
    public class EditModel : PageModel
    {
        private readonly Realpath.NewWebSite.Data.RealpathNewWebSiteContext _context;

        public EditModel(Realpath.NewWebSite.Data.RealpathNewWebSiteContext context)
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

            var companyinfo =  await _context.CompanyInfo.FirstOrDefaultAsync(m => m.id == id);
            if (companyinfo == null)
            {
                return NotFound();
            }
            CompanyInfo = companyinfo;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CompanyInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompanyInfoExists(CompanyInfo.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CompanyInfoExists(int id)
        {
          return (_context.CompanyInfo?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
