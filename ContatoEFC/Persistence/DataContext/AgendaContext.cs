using ContatoEFC.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContatoEFC.Persistence.DataContext
{
    public class AgentaContext : DbContext
    {
        public DbSet<Agenda> Agenda { get; set; }

        public AgentaContext(DbContextOptions options) : base(options)
        {

        }
    }
}
