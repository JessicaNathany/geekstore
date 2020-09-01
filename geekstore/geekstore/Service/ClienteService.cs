using geekstore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace geekstore.Service
{
    public class ClienteService : IClienteService
    {
        public bool Comprar(Cliente cliente, Produto produto)
        {
            if(produto.Ativo == false)
            {
                return false;
            }

            if(cliente.Ativo == false)
            {
                return false;
            }

            if(produto.Valor <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
