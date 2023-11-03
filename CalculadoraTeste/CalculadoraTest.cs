

using Calculadora;

namespace CalculadoraTeste
{
    public class CalculadoraTest
    {

        private CalculadoraInpl calculadora;

        public CalculadoraTest()
        {
            calculadora= new CalculadoraInpl();
        }



        [Fact]
        public void calcularSeSoma4Mais4TaRetornando8()
        {
            //Arrange(Preparação)

            int numero1 = 4; 
            int numero2 = 4;

            int resultadoEsperado = 8;

            //Action(Ação)

            int resultadoActual = calculadora.somar(numero1, numero2);

            //Assert(Afirmação)

            Assert.Equal(resultadoEsperado, resultadoActual);
        }

        [Fact]
        public void calcularSomaComNumerosPositivos()
        {
            // Arrange
            int numero1 = 3;
            int numero2 = 5;
            int resultadoEsperado = 8;

            // Act
            int resultadoActual = calculadora.somar(numero1, numero2);

            // Assert
            Assert.Equal(resultadoEsperado, resultadoActual);
        }

        [Fact]
        public void calcularSomaComNumerosNegativos()
        {
            // Arrange
            int numero1 = -3;
            int numero2 = -5;
            int resultadoEsperado = -8;

            // Act
            int resultadoActual = calculadora.somar(numero1, numero2);

            // Assert
            Assert.Equal(resultadoEsperado, resultadoActual);
        }

        [Fact]
        public void calcularSomaComZero()
        {
            // Arrange
            int numero1 = 0;
            int numero2 = 7;
            int resultadoEsperado = 7;

            // Act
            int resultadoActual = calculadora.somar(numero1, numero2);

            // Assert
            Assert.Equal(resultadoEsperado, resultadoActual);
        }



        // Testa o método de Subtrair


        [Fact]
        public void calcularSeSubtracao10Menos2Eh8()
        {

            // Arrange
            int numero1 = 10;
            int numero2 = 2;
            int resultadoEsperado = 8;

            // Act
            int resultadoActual = calculadora.subtrair(numero1,numero2);

            // Assert
            Assert.Equal(resultadoEsperado, resultadoActual);

        }


        // Testa o método multiplicação


        [Theory]
        [InlineData(5,2,10)]
        public void calcularSeMultiplicacao5Vezes2Eh10(int numero1 ,int numero2,int resultadoesperado)
        {

            // Arrange

            // Act

            int resultadoActual = calculadora.multiplicar(numero1, numero2);


            // Assert

            Assert.Equal(resultadoesperado, resultadoActual);


        }



        //Testar o método Dividir


        [Theory]
        [InlineData(10, 2, 5)]
        public void clacularSeDivisao10por2Eh5(int nunero1, int numero2, int resultadoesperado)
        {

            // Arrange

            // Act
            int resultadoActual = calculadora.dividir(nunero1, numero2);


            // Assert

            Assert.Equal(resultadoesperado, resultadoActual);


        }

        [Fact]
        public void testarDivisaoPorZero()
        {

            // Arrange

            int numero1 = 10;
            int numer02 = 0;

            // Act
            // Assert
            Assert.Throws<DivideByZeroException>(() => calculadora.dividir(numero1, numer02));



        }

        // testar o Historico

        [Fact]
        public void verificarSeListaNaoTaVazia()
        {

            // Arrange
            calculadora.somar(1, 2);
            calculadora.subtrair(10, 2);
            calculadora.somar(1, 2);
            calculadora.subtrair(10, 2);

            // Act

            var lista =   calculadora.historico();
            // Assert

            Assert.NotEmpty(lista);
           


        }


        [Fact]
        public void verificarSeListaSoTem3Historico()
        {

            // Arrange
            calculadora.somar(1, 2);
            calculadora.subtrair(10, 2);
            calculadora.somar(1, 3);
            calculadora.dividir(6, 2);

            int resultadoesperado = 3;

            // Act

            var lista = calculadora.historico();
            // Assert

            Assert.Equal(3, lista.Count);



        }


















    }

}