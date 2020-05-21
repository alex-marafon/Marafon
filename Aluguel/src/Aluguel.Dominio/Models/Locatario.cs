using System;
using System.Collections.Generic;
using System.Text;

namespace Aluguel.Dominio.Models
{
    class Locatario : DadosPessoa
    {
        public Locatario() 
        {
            var LocatarioId = Guid.NewGuid();
        }

        public string LocatarioId { get; set; }
    }
}
