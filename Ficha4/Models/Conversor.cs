using System.ComponentModel.DataAnnotations;

namespace Ficha4.Models
{
    public class Conversor
    {
        [Display(Name = "Converter de ")]
        public int UnidadeInicial { get; set; }

        [Display(Name = "Para         ")]
        public int UnidadeFinal { get; set; }

        [Display(Name = "Valor a converter")]
        public double ValorIncial { get; set; }

        [Display(Name = "Valor final")]
        public double ValorFinal { get; set; }

        [Display(Name = "Taxa de cambio")]
        public double TaxaDeCambio { get; set; }
    }
}
