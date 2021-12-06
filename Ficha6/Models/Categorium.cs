using System;
using System.Collections.Generic;

#nullable disable

namespace Ficha6.Models
{
    public partial class Categorium
    {
        public Categorium()
        {
            Produtos = new HashSet<Produto>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
