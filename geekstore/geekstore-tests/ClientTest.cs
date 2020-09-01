using System;
using Xunit;
using geekstore;
using geekstore.Model;
using geekstore.Service;

namespace geekstore_tests
{
    public class ClientTest
    {
        [Fact(DisplayName = "Cliente - compra produtos inativo Erro")]
        [Trait("Categoria", "Compras")]
        public void Cliente_Comprar_ComprarProdutosInativos()
        {
            var cliente = new Cliente()
            {
                Id = 1,
                Ativo = true,
                Email = "fulano@teste",
                Nome = "Fulano"
            };

            var produto = new Produto()
            {
                Id = 1,
                Ativo = false,
                Nome = "Bola",
                Valor = 50m,
                Descricao = "Bola de futebol Nike"
            };

            var clienteService= new ClienteService();

            // Arrange

            // Act
            var result = clienteService.Comprar(cliente, produto);

            // Assert
            Assert.False(result);
        }


        [Fact(DisplayName = "Cliente - cliente inativo plataforma")]
        [Trait("Cliente", "Compras")]
        public void Cliente_Comprar_ClienteInativo()
        {
            // Arrange
            var cliente = new Cliente()
            {
                Id = 1,
                Ativo = false,
                Email = "fulano@teste",
                Nome = "Fulano"
            };

            var produto = new Produto()
            {
                Id = 1,
                Ativo = true,
                Nome = "Bola",
                Valor = 50m,
                Descricao = "Bola de futebol Nike"
            };

            var clienteService = new ClienteService();

            // Act
            var result = clienteService.Comprar(cliente, produto);

            // Assert
            Assert.False(result);
        }


        [Fact(DisplayName = "Cliente - produto menor ou igual a zero")]
        [Trait("Cliente", "Compras")]
        public void Cliente_Comprar_ProdutoMenorOuIguaZero()
        {
            // Arrange
            var cliente = new Cliente()
            {
                Id = 1,
                Ativo = true,
                Email = "fulano@teste",
                Nome = "Fulano"
            };

            var produto = new Produto()
            {
                Id = 1,
                Ativo = true,
                Nome = "Bola",
                Valor = 0,
                Descricao = "Bola de futebol Nike"
            };

            var clienteService = new ClienteService();

            // Act
            var result = clienteService.Comprar(cliente, produto);

            // Assert
            Assert.False(result);
            Assert.Equal(0, produto.Valor);
        }
    }
}
