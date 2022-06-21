using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ConcentrameApi.Models;

namespace ConcentrameApi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ConcentrameApi.Models.Link> Link { get; set; }
        public DbSet<ConcentrameApi.Models.Notice> Notice { get; set; }
    }
}
