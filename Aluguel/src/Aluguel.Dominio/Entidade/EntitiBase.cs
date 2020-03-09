using System;
using System.Collections.Generic;
using System.Text;

namespace Aluguel.Dominio.Entidade
{
    public class EntitiBase
    {
        public EntitiBase()
        {
            this.Id = new Guid();
        }
        public Guid Id { get; set; }
    }
}
