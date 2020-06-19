using System.ComponentModel.DataAnnotations;

namespace Aluguel.Dominio.Models
{
    public class DadosPessoa
    {


        [Required]
        public string Nome { get; set; }
        [Required]
        public string SobreNome { get; set; }
        [Required]
        public decimal Cpf { get; set; }
        [Required]
        public decimal Rg { get; set; }
        [Required]
        [Display(Name = "Orgão Emissor")]
        public string OrgaoEmissor { get; set; }
        [Required]
        [Display(Name = "Profissão")]
        public string Profissao { get; set; }

        public string EstadoCivil { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public decimal Tel { get; set; }
        [Required]
        public decimal TelTestemunha { get; set; }

        //Concatenar Nome e Sobrenome - Retornar "Nome Completo"

    }
}
