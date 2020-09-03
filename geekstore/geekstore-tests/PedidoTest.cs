using geekstore.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace geekstore_tests
{
    public class PedidoTest
    {
        [Fact(DisplayName = "Pedido")]
        [Trait("Categoria", "Pedido Tests")]
        public void CriarPedido_AdicionarCliente_NaoPodeSerVazioOuNulo()
        {
            // Arrange  Act
            var pedido = new Pedido(1, DateTime.Now, 1);

            // Assert
            Assert.False(String.IsNullOrEmpty(pedido.IdCliente.ToString()));

        }
    }
}
