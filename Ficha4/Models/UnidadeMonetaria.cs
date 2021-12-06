using System;
using System.ComponentModel.DataAnnotations;

namespace Ficha4.Models
{
    public class UnidadeMonetaria
    {
        public int Id { get; set; }
        public string Codigo { get; set; }

        [Display(Name="Valor por Euro")]
        public double Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
