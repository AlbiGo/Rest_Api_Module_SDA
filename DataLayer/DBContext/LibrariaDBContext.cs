using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DBContext
{
    public class LibrariaDBContext : DbContext
    {
        public LibrariaDBContext(DbContextOptions<LibrariaDBContext> dbContextOptions)
            : base(dbContextOptions)
        {
        }

        DbSet<Lexues> Lexuesit { get; set; }
        DbSet<Liber> Librat { get; set; }
        DbSet<LiberLexues> LiberLexues { get; set; }
        DbSet<Kategori> Kategorite { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseLazyLoadingProxies();
        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
