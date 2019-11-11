using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProojectMVC.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalcularPotenciaDosAlaDos()
        {
            //Arange
            ProjectMVC.Logica.Services.TestClas test = new ProjectMVC.Logica.Services.TestClas();
            
            int numero = 2;
            int potencia = 2;

            //Act
            double result = test.CalcularPotencia(numero, potencia);

            //Assert
            Assert.AreEqual(result, 4);
        }
    }
}
