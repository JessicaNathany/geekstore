using geekstore.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace geekstore.Model
{
    public class Produto : Entity
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        public decimal Valor { get; set; }

        public Produto(int id,string nome, string descricao, bool ativo, decimal valor)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Ativo = ativo;
            Valor = valor;
        }
    }
}
