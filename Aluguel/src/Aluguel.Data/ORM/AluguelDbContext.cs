using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aluguel.Data.ORM
{
   public class AluguelDbContext : DbContext
    {
        public AluguelDbContext(DbContextOptions<AluguelDbContext> options) : base(options) 
        {
        
        }
    }
}
