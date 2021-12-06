using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Ficha6.Models
{
    public partial class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Preço")]
        public int Preco { get; set; }

  
        public int IdCategoria { get; set; }

        [Display(Name = "Categoria")]
        public virtual Categorium IdCategoriaNavigation { get; set; }
    }
}
