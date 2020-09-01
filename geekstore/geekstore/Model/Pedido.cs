using System;
using System.Collections.Generic;
using System.Text;

namespace geekstore.Model
{
    public class Pedido
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public int IdCliente { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
