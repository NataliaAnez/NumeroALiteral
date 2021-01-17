using Convertir_de_numero_a_literal.Controllers;
using NUnit.Framework;

namespace NUnitTestNumeroALiteral
{
    public class TestLiteral
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestNumeroGet()
        {

            //Arange=Preparación
            string num1 = "5";
            string esperado = "Cinco";
            
            LiteralController lit = new LiteralController();

            //Act=Ejecución

            string resultado = lit.NumeroGet(num1);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestNumeroPost()
        {

            //Arange=Preparación
            string num1 = "98";
            string esperado = "Noventa y Ocho";

            LiteralController lit = new LiteralController();

            //Act=Ejecución

            string resultado = lit.NumeroPost(num1);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }

    }
}