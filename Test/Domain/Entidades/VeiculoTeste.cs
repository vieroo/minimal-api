using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using minimal_api.Dominio.Entidades;

namespace Test.Domain.Entidades
{
    [TestClass]
    public class VeiculoTeste
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var veiculo = new Veiculo(nome: "Fiesta", "Ford", 2020);

            // Act
            veiculo.Id = 1;

            // Assert
            Assert.AreEqual(1, veiculo.Id);
            Assert.AreEqual("Ford", veiculo.Marca);
            Assert.AreEqual(2020, veiculo.Ano);
            Assert.AreEqual("Fiesta", veiculo.Nome);
        }
    }
}