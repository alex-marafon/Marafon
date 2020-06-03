using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Aluguel.Dominio.Models
{
  public  class Imovel
    {
        public int ImovelId { get; set; }
        [Required]
        [Display(Name ="Nome Imovel")]
        public string NomeImovel { get; set; }

        //Futuramente sera um Enum -----------
        public string Estado { get; set; } 
        public string Cidade { get; set; }
        //-----------------------------------

        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Rua { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        [Display(Name = "CEP")]
        public int Cep { get; set; }


    }

  
}
