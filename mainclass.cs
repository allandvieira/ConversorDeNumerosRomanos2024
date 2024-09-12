namespace ConversorDeNumerosRomanos.Dominio
{
    public class ConversorNumeroRomano
    {
        Dictionary<int, string> numeros;
        public ConversorNumeroRomano()
        {
            numeros = new Dictionary<int, string>();
            numeros.Add(1, "I");
            numeros.Add(2, "II");
            numeros.Add(3, "III");
            numeros.Add(4, "IV");
            numeros.Add(5, "V");
            numeros.Add(6, "VI");
            numeros.Add(7, "VII");
            numeros.Add(8, "VIII");
            numeros.Add(9, "IX");
            numeros.Add(10, "X");
        }

        public string Converter(int numeroArabico)
        {
            if (numeroArabico == 10)
                return "X";

            else if (numeroArabico > 100)
            {
                int n = numeroArabico - 100;
                return "C" + numeros[n];
            }

            else if (numeroArabico == 100)
            {
                return "C";
            }

            else if (numeroArabico > 90)
            {
                int n = numeroArabico - 90;
                return "XC" + numeros[n];
            }

            else if (numeroArabico == 90)
            {
                return "XC";
            }

            else if (numeroArabico > 80)
            {
                int n = numeroArabico - 80;
                return "LXXX" + numeros[n];
            }

            else if (numeroArabico > 70)
            {
                int n = numeroArabico - 70;
                return "LXX" + numeros[n];
            }

            else if (numeroArabico > 60)
            {
                int n = numeroArabico - 60;
                return "LX" + numeros[n];
            }

            else if (numeroArabico > 50)
            {
                int n = numeroArabico - 50;
                return "L" + numeros[n];
            }

            else if (numeroArabico == 50)
            {
                return "L";
            }

            else if (numeroArabico > 40)
            {
                int n = numeroArabico - 40;
                return "XL" + numeros[n];
            }

            else if (numeroArabico == 40)
            {
                return "XL";
            }

            else if (numeroArabico > 30)
            {
                int n = numeroArabico - 30;
                return "XXX" + numeros[n];
            }

            else if (numeroArabico > 20)
            {
                int n = numeroArabico - 20;
                return "XX" + numeros[n];
            }

            else if (numeroArabico > 10)
            {
                int n = numeroArabico - 10;
                return "X" + numeros[n];
            }

            return numeros[numeroArabico];
        }
    }
}
