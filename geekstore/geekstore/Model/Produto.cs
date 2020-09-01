using System;
using System.Collections.Generic;
using System.Text;

namespace geekstore.Model
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        public decimal Valor { get; set; }
    }
}
