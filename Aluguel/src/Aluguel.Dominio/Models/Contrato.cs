using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aluguel.Dominio.Models
{
    public class Contrato
    {
        public Contrato()
        {
            Locatarios = new HashSet<Locatario>();
            Locadores = new HashSet<Locador>();
            Imovels = new HashSet<Imovel>();
        }

        public int ContratoId { get; set; }

        [Required]
        public int LocadorId { get; set; }
        public Locador Locador { get; set; }

        [Required]
        public int LocatarioId { get; set; }
        public Locatario Locatario { get; set; }

        [Required]
        public int imovelId { get; set; }
        public Imovel Imovel { get; set; }

        [Required]
        public DateTime DataContrato { get; set; }
        [Required]
        public DateTime DiaVencimentoAlguel { get; set; }
        [Required]
        public DateTime DataInicio { get; set; }
        [Required]
        public DateTime DataFim { get; set; }

        public bool Status { get; set; }



        public virtual ICollection<Locatario> Locatarios { get; set; }
        public virtual ICollection<Locador> Locadores { get; set; }
        public virtual ICollection<Imovel> Imovels { get; set; }


    }
}
