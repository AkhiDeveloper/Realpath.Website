using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Realpath.NewWebSite.Data;
using Realpath.NewWebSite.Data.Models;

namespace Realpath.NewWebSite.Pages.Contactus
{
    public class CreateModel : PageModel
    {
        private readonly Realpath.NewWebSite.Data.RealpathNewWebSiteContext _context;

        public CreateModel(Realpath.NewWebSite.Data.RealpathNewWebSiteContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CompanyInfo CompanyInfo { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.CompanyInfo == null || CompanyInfo == null)
            {
                return Page();
            }

            _context.CompanyInfo.Add(CompanyInfo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
