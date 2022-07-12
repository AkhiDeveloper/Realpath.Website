using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Realpath.NewWebSite.Data.Models;

namespace Realpath.NewWebSite.Data
{
    public class RealpathNewWebSiteContext : DbContext
    {
        public RealpathNewWebSiteContext (DbContextOptions<RealpathNewWebSiteContext> options)
            : base(options)
        {
        }

        public DbSet<CompanyInfo>? CompanyInfo { get; set; }
        public DbSet<Address>? addresses { get; set; }
        public DbSet<ContactDetail>? contactDetails { get; set; }
        public DbSet<Designation>? designations { get; set; }
        public DbSet<Member>? members { get; set; }
        public DbSet<Photo>? gallery { get; set; }
        public DbSet<Project>? projects { get; set; }
        public DbSet<Service>? services { get; set; }
    }
}
