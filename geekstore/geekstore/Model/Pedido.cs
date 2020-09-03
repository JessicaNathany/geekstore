using geekstore.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace geekstore.Model
{
    public class Pedido : Entity
    {
        public DateTime Data { get; private set; }

        public int IdCliente { get; private set; }

        public List<Produto> Produtos { get; private set; }

        public Pedido(int id, DateTime data, int idCliente)
        {
            Id = id;
            Data = data;
            IdCliente = idCliente;
        }
    }
}
