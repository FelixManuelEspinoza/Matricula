using MatriculaBD.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaBD.Data
{
    public class BDcontext : DbContext
    {
        public DbSet<Medico> Medicos { get; set; }

        public BDcontext()
        {

        }
        public BDcontext(DbContextOptions options) : base(options)
        {

        }
    }
}
