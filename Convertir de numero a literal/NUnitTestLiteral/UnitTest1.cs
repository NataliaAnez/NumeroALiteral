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
            //Arange=Preparación
            int num1 = 5;
            string esperado = " Cinco ";
            LiteralController lit= new LiteralController();

            //Act=Ejecución

            string resultado = lit.NumeroGet( num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }
    }
}