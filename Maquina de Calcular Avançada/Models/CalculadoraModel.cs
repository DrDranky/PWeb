using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Maquina_de_Calcular_Avançada.Models
{
    public class CalculadoraModel
    {
        [Display(Name = "Primeiro Operando")]
        public string op1 { get; set; }

        [Display(Name = "Segundo Operando")]
        public string op2 { get; set; }

        [Display(Name = "Resultado")]
        public string resultado { get; set; }

        [Display(Name = "Número de Dígitos")]
        public int NDigitos { get; set; }
        
        public SelectList Digitos { get; set; }

        public CalculadoraModel()
        {
            Digitos = MaquinaDeCalcular.AppCode.DigitosDecimais.ListaDigitosDecimais();
        }

    }
}
