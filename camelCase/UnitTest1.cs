namespace camelCase
{
    public class UnitTest1
    {
        [Fact]
        public void ConverterCamelCase()
        {
            var conversor = new Conversor();
            var listaConjuntos = PrepararMontagemConjuntos();
            var conversao1 = conversor.ConverterParaCamelCase(listaConjuntos.conjunto1);
            var conversao2 = conversor.ConverterParaCamelCase(listaConjuntos.conjunto2);
            var conversao3 = conversor.ConverterParaCamelCase(listaConjuntos.conjunto3);
            var conversao4 = conversor.ConverterParaCamelCase(listaConjuntos.conjunto4);
            Assert.Equal("NomeComposto", conversao1);
            Assert.Equal("NumeroCpf", conversao2);
            Assert.Equal("NumeroCpfContribuinte", conversao3);
            Assert.Equal("NomeComposto", conversao4);
        }

        (List<string> conjunto1, List<string> conjunto2, List<string> conjunto3, List<string> conjunto4) PrepararMontagemConjuntos()
        {
            var conjuntoPalavras1 = MontarConjuntoPalavras1();
            var conjuntoPalavras2 = MontarConjuntoPalavras2();
            var conjuntoPalavras3 = MontarConjuntoPalavras3();
            var conjuntoPalavras4 = MontarConjuntoPalavras4();
            return (conjuntoPalavras1, conjuntoPalavras2, conjuntoPalavras3, conjuntoPalavras4);
        }

        public List<string> MontarConjuntoPalavras1()
        {
            return new List<string>
            {
                "nome",
                "composto"
            };
        }
        public List<string> MontarConjuntoPalavras2()
        {
            return new List<string>
            {
                "numero",
                "CPF",
            };
        }
        public List<string> MontarConjuntoPalavras3()
        {
            return new List<string>
            {
                "numero",
                "CPF",
                "contribuinte",
            };
        }
        public List<string> MontarConjuntoPalavras4()
        {
            return new List<string>
            {
                "nome",
                "composto"
            };
        }
    }
}