using geekstore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace geekstore.Service
{
    public interface IClienteService
    {
        bool Comprar(Cliente cliente, Produto produto);
    }
}
