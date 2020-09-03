using geekstore.Core;
using System;

namespace geekstore
{
    public class Cliente : Entity
    {
        public string Nome { get; private set; }

        public string Email { get; private set; }

        public bool Ativo { get; private set; }

        public Cliente(int id,string nome, string email, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Ativo = ativo;
        }
    }
}
