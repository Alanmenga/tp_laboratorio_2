using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitSupermercado
    {
        /// <summary>
        /// test unitario que valida que la lista
        /// de productos esté instanciada al
        /// crear un nuevo objeto del tipo supermercado
        /// </summary>
        [TestMethod]
        public void PaqueteInstanciado()
        {
            //Arrange
            Supermercado supermercado; 
            //Act
            supermercado = new Supermercado();
            //Assert
            Assert.IsInstanceOfType(supermercado.Productos, typeof(List<Producto>));
        }

        /// <summary>
        /// test unitario que valida la excepción IdProductoRepetidoException
        /// se lance al intentar cargar un segundo producto con el mismo numero de ID
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(IdProductoRepetidoException))]
        public void PaquetesIguales()
        {
            //Arrange
            Supermercado s;
            Producto p1;
            Producto p2;
            //Act
            s = new Supermercado();
            p1 = new Producto("sarasa", "0303456");
            p2 = new Producto("sin nombre", "0303456");
            //Assert
            s += p1;
            s += p2;
        }
    }
}
