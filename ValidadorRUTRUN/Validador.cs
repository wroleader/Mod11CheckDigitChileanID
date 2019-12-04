using System;
using System.Linq;

namespace ValidadorRUTRUN
{
    class Validador
    {
        public string VerifiRut(string RUN)
        {
            string myRUN = RUN;
            
            var multDigits = new int[] {2, 3, 4, 5, 6, 7, 2, 3, 4, 5, 6, 7, 2, 3, 4, 5, 6, 7};

            var elimCharacters = new string[] { ".", "-" };

            foreach (var c in elimCharacters)
            {
                myRUN = myRUN.Replace(c, string.Empty);
            }

            myRUN = Validador.Inversor(myRUN);

            var intArray = new int[myRUN.Length];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(myRUN[i].ToString());
            }

            var resultArray = new int[intArray.Length];

            for (int i = 0; i < myRUN.Length; i++)
            {
                resultArray[i] = intArray[i] * multDigits[i];
            }

            var totalSum = resultArray.Sum();

            var modRem = totalSum % 11;

            var digVerificador = 11 - modRem;

            var digVerif = digVerificador.ToString();

            if (digVerif == "10")
            {
                digVerif = "K";
                return digVerif;
            }
            else if (digVerif == "11")
            {
                digVerif = "0";
                return digVerif;
            }
            else
            {
                return digVerif;
            }
        }
        private static string Inversor(string entrada)
        {
            char[] salida = entrada.ToCharArray();
            Array.Reverse(salida);
            return new string(salida);
        }
    }
}
