using System;
using System.Collections.Generic;
using System.Text;

namespace Aluguel.Dominio.Models
{
   public class Locatario : DadosPessoa
    {


        public int LocatarioId { get; set; }

        public bool Status { get; set; }



        public virtual ICollection<Locatario> Locatarios { get; set; }


    }
}
