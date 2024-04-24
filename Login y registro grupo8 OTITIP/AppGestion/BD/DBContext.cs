using Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class DBContext : DbContext
    {
        public DbSet<Usuario> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string directorioActual = Directory.GetCurrentDirectory();

            int indiceBin = directorioActual.LastIndexOf("bin", StringComparison.OrdinalIgnoreCase);

            string rutaCarpetaPadre = indiceBin >= 0 ? directorioActual.Substring(0, indiceBin) : directorioActual;

            string archivoDB = "BD\\AppGestion.db";
            string connString = rutaCarpetaPadre + archivoDB;
            optionsBuilder.UseSqlite($"Data source={connString}");
        }

        public DBContext()
        {

        }
    }
}
