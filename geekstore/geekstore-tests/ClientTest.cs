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
            var cliente = new Cliente(1, "Fulano", "fulano@teste.com", true);

            var produto = new Produto(1, "Bola", "Bola de Futebol", false, 50m);

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
            var cliente = new Cliente(1, "Fulano", "fulano@teste.com", false);

            var produto = new Produto(1, "Bola", "Bola de Futebol", true, 50m);

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
            var cliente = new Cliente(1, "Fulano", "fulano@teste.com", true);

            var produto = new Produto(1, "Bola", "Bola de Futebol", true, 0m);

            var clienteService = new ClienteService();

            // Act
            var result = clienteService.Comprar(cliente, produto);

            // Assert
            Assert.False(result);
            Assert.Equal(0, produto.Valor);
        }
    }
}
