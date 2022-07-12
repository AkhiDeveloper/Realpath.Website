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
    public class IndexModel : PageModel
    {
        private readonly Realpath.NewWebSite.Data.RealpathNewWebSiteContext _context;

        public IndexModel(Realpath.NewWebSite.Data.RealpathNewWebSiteContext context)
        {
            _context = context;
        }

        public IList<CompanyInfo> CompanyInfo { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.CompanyInfo != null)
            {
                CompanyInfo = await _context.CompanyInfo.ToListAsync();
            }
        }
    }
}
