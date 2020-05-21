using System;
using System.Collections.Generic;
using System.Text;

namespace Aluguel.Dominio.Models
{
    class Locador : DadosPessoa
    {
        public Locador()
        {
            var LocadorId = Guid.NewGuid();
        }

        public int LocadorId { get; set; }
    }
}
