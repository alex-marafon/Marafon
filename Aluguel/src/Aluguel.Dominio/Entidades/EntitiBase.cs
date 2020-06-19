using System;

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
