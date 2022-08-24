using backendTarjetas.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendTarjetas.context
{
    public class DBContext: DbContext
    {
        public DbSet<TarjetaCredito> TarjetaCreditos { get; set; }
        public DBContext(DbContextOptions<DBContext> options): base(options)
        {

        }
    }
}
