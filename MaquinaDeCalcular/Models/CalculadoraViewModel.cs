using System.ComponentModel.DataAnnotations;

namespace MaquinaDeCalcular.Models
{
    public class CalculadoraViewModel
    {
        

        [Display(Name="Primeiro Operando")]
        public string op1 { get; set; }
        [Display(Name = "Segundo Operando")]
        public string op2 { get; set; }
        [Display(Name = "Resultado")]
        public string resultado { get; set; }

    }
}
