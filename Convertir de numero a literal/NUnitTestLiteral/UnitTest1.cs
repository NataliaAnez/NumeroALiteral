using NUnit.Framework;

namespace NUnitTestLiteral
{
    public class TestConvertirALiteral
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestLiteralGet1()
        { 
            //Arange=Preparaci�n
            int num1 = 5;
            string esperado = " Cinco ";
            LiteralController lit= new LiteralController();

            //Act=Ejecuci�n

            string resultado = lit.NumeroGet( num1, num2);

            //Assert=Verificaci�n
            Assert.AreEqual(esperado, resultado);

        }
    }
}