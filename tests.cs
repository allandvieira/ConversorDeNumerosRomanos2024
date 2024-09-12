using ConversorDeNumerosRomanos.Dominio;

namespace ConversorDeNumerosRomanos.Testes.Unidade
{
    [TestClass]
    public class ConversorNumeroRomanoTests
    {
        [TestMethod]
        [DataRow(1, "I")]
        [DataRow(2, "II")]
        [DataRow(3, "III")]
        [DataRow(4, "IV")]
        [DataRow(5, "V")]
        [DataRow(6, "VI")]
        [DataRow(7, "VII")]
        [DataRow(8, "VIII")]
        [DataRow(9, "IX")]
        public void Teste_de_1_9(int numero, string numeroRomano)
        {
            var conversor = new ConversorNumeroRomano();

            string resultado = conversor.Converter(numero);

            Assert.AreEqual(numeroRomano, resultado);
        }

        [TestMethod]
        [DataRow(10, "X")]
        [DataRow(11, "XI")]
        [DataRow(12, "XII")]
        [DataRow(13, "XIII")]
        [DataRow(14, "XIV")]
        [DataRow(15, "XV")]
        [DataRow(16, "XVI")]
        [DataRow(17, "XVII")]
        [DataRow(18, "XVIII")]
        [DataRow(19, "XIX")]
        public void Teste_de_10_19(int numero, string numeroRomano)
        {
            var conversor = new ConversorNumeroRomano();

            string resultado = conversor.Converter(numero);

            Assert.AreEqual(numeroRomano, resultado);
        }

        [TestMethod]
        [DataRow(20, "XX")]
        [DataRow(21, "XXI")]
        [DataRow(22, "XXII")]
        [DataRow(23, "XXIII")]
        [DataRow(24, "XXIV")]
        [DataRow(25, "XXV")]
        [DataRow(26, "XXVI")]
        [DataRow(27, "XXVII")]
        [DataRow(28, "XXVIII")]
        [DataRow(29, "XXIX")]
        public void Teste_de_20_29(int numero, string numeroRomano)
        {
            var conversor = new ConversorNumeroRomano();

            string resultado = conversor.Converter(numero);

            Assert.AreEqual(numeroRomano, resultado);
        }

        [TestMethod]
        [DataRow(30, "XXX")]
        [DataRow(31, "XXXI")]
        [DataRow(32, "XXXII")]
        [DataRow(33, "XXXIII")]
        [DataRow(34, "XXXIV")]
        [DataRow(35, "XXXV")]
        [DataRow(36, "XXXVI")]
        [DataRow(37, "XXXVII")]
        [DataRow(38, "XXXVIII")]
        [DataRow(39, "XXXIX")]
        public void Teste_de_30_39(int numero, string numeroRomano)
        {
            var conversor = new ConversorNumeroRomano();

            string resultado = conversor.Converter(numero);

            Assert.AreEqual(numeroRomano, resultado);
        }

        [TestMethod]
        [DataRow(40, "XL")]
        [DataRow(41, "XLI")]
        [DataRow(42, "XLII")]
        [DataRow(43, "XLIII")]
        [DataRow(44, "XLIV")]
        [DataRow(45, "XLV")]
        [DataRow(46, "XLVI")]
        [DataRow(47, "XLVII")]
        [DataRow(48, "XLVIII")]
        [DataRow(49, "XLIX")]
        public void Teste_de_40_49(int numero, string numeroRomano)
        {
            var conversor = new ConversorNumeroRomano();

            string resultado = conversor.Converter(numero);

            Assert.AreEqual(numeroRomano, resultado);
        }

        [TestMethod]
        [DataRow(50, "L")]
        [DataRow(51, "LI")]
        [DataRow(52, "LII")]
        [DataRow(53, "LIII")]
        [DataRow(54, "LIV")]
        [DataRow(55, "LV")]
        [DataRow(56, "LVI")]
        [DataRow(57, "LVII")]
        [DataRow(58, "LVIII")]
        [DataRow(59, "LIX")]
        public void Teste_de_50_59(int numero, string numeroRomano)
        {
            var conversor = new ConversorNumeroRomano();

            string resultado = conversor.Converter(numero);

            Assert.AreEqual(numeroRomano, resultado);
        }

        [TestMethod]
        [DataRow(60, "LX")]
        [DataRow(61, "LXI")]
        [DataRow(62, "LXII")]
        [DataRow(63, "LXIII")]
        [DataRow(64, "LXIV")]
        [DataRow(65, "LXV")]
        [DataRow(66, "LXVI")]
        [DataRow(67, "LXVII")]
        [DataRow(68, "LXVIII")]
        [DataRow(69, "LXIX")]
        public void Teste_de_60_69(int numero, string numeroRomano)
        {
            var conversor = new ConversorNumeroRomano();

            string resultado = conversor.Converter(numero);

            Assert.AreEqual(numeroRomano, resultado);
        }

        [TestMethod]
        [DataRow(70, "LXX")]
        [DataRow(71, "LXXI")]
        [DataRow(72, "LXXII")]
        [DataRow(73, "LXXIII")]
        [DataRow(74, "LXXIV")]
        [DataRow(75, "LXXV")]
        [DataRow(76, "LXXVI")]
        [DataRow(77, "LXXVII")]
        [DataRow(78, "LXXVIII")]
        [DataRow(79, "LXXIX")]
        public void Teste_de_70_79(int numero, string numeroRomano)
        {
            var conversor = new ConversorNumeroRomano();

            string resultado = conversor.Converter(numero);

            Assert.AreEqual(numeroRomano, resultado);
        }

        [TestMethod]
        [DataRow(80, "LXXX")]
        [DataRow(81, "LXXXI")]
        [DataRow(82, "LXXXII")]
        [DataRow(83, "LXXXIII")]
        [DataRow(84, "LXXXIV")]
        [DataRow(85, "LXXXV")]
        [DataRow(86, "LXXXVI")]
        [DataRow(87, "LXXXVII")]
        [DataRow(88, "LXXXVIII")]
        [DataRow(89, "LXXXIX")]
        public void Teste_de_80_89(int numero, string numeroRomano)
        {
            var conversor = new ConversorNumeroRomano();

            string resultado = conversor.Converter(numero);

            Assert.AreEqual(numeroRomano, resultado);
        }

        [TestMethod]
        [DataRow(90, "XC")]
        [DataRow(91, "XCI")]
        [DataRow(92, "XCII")]
        [DataRow(93, "XCIII")]
        [DataRow(94, "XCIV")]
        [DataRow(95, "XCV")]
        [DataRow(96, "XCVI")]
        [DataRow(97, "XCVII")]
        [DataRow(98, "XCVIII")]
        [DataRow(99, "XCIX")]
        public void Teste_de_90_99(int numero, string numeroRomano)
        {
            var conversor = new ConversorNumeroRomano();

            string resultado = conversor.Converter(numero);

            Assert.AreEqual(numeroRomano, resultado);
        }

        [TestMethod]
        [DataRow(100, "C")]
        [DataRow(101, "CI")]
        [DataRow(102, "CII")]
        [DataRow(103, "CIII")]
        [DataRow(104, "CIV")]
        [DataRow(105, "CV")]
        [DataRow(106, "CVI")]
        [DataRow(107, "CVII")]
        [DataRow(108, "CVIII")]
        [DataRow(109, "CIX")]
        public void Teste_de_100_109(int numero, string numeroRomano)
        {
            var conversor = new ConversorNumeroRomano();

            string resultado = conversor.Converter(numero);

            Assert.AreEqual(numeroRomano, resultado);
        }
    }
}
