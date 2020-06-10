using Aluguel.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Aluguel.Dominio.Models
{
   public class Contrato
    {
        public int ContratoId { get; set; }

        [Required]
        public int  LocadorId { get; set; }
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


    }
}
