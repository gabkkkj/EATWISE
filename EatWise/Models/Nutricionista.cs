using System.ComponentModel.DataAnnotations;

namespace EatWise.Models
{
    public class Nutricionista
    {
        public Guid NutricionistaId { get; set; }
        public string Nome { get; set; }
        public string CRM { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DisponibilidadeInicio { get; set; }
        public DateTime DisponibilidadeFinal {  get; set; }
        [Display(Name =("Formação"))]
        public string Formacao { get; set; }
        [Display(Name = ("Especialização"))]
        public string Especializacao { get; set; }
        public string FotoPerfil { get; set; }
    }
}
