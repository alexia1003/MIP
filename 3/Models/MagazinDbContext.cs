using Proiect3_MIP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proiect3_MIP
{
    public class MagazinDbContext : DbContext
    {
        public DbSet<Produs> Produse { get; set; }
        public DbSet<Cumparare> Cumparaturi { get; set; }
    }



}  