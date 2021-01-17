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
            string num1 = "5";
            string esperado = " Cinco ";
            LiteralController lit= new LiteralController();

            //Act=Ejecuci�n

            string resultado = lit.( num1);

            //Assert=Verificaci�n
            Assert.AreEqual(esperado, resultado);

        }
    }
}