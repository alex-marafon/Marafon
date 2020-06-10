using System;
using System.Collections.Generic;
using System.Text;

namespace Aluguel.Dominio.Models
{
  public  class Locador : DadosPessoa
    {


        public int LocadorId { get; set; }

        public bool Status { get; set; }



        public virtual ICollection<Locador> Locadores { get; set; }
    }
}
