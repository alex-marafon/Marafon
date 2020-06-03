using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Aluguel.Dominio.Models;



namespace Aluguel.Data.ORM
{
   public class AluguelDbContext : DbContext
    {
        public AluguelDbContext(DbContextOptions<AluguelDbContext> options) 
            : base(options) 
        {
        }

        public DbSet<Imovel> Imovels { get; set; }
        public DbSet<Imagem> Imagems { get; set; }
        public DbSet<Locador> Locadores { get; set; }
        public DbSet<Locatario> Locatarios { get; set; }



    }
}
