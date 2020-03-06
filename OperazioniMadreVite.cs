using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRAlpha2
{
    public class OperazioniMadreVite
    {
    
        public double getScostamento(string classeDiamInterno, string classeDiamMedio, double passo)
        {
            double risultato = 0.0;
            string condition = classeDiamInterno;

            switch (condition)
            {
                case "4G":
                    risultato = 0.015 + 0.011 * passo;
                    break;

                case "4E":
                    risultato = 0.05 + 0.011 * passo;
                    break;

                case "5G":
                    risultato = 0.015 + 0.011 * passo;
                    break;

                case "6G":
                    risultato = 0.015 + 0.011 * passo;
                    break;

                case "6E":
                    risultato = 0.05 + 0.011 * passo;
                    break;

                case "7G":
                    risultato = 0.015 + 0.011 * passo;
                    break;

                case "7E":
                    risultato = 0.05 + 0.011 * passo;
                    break;

                case "8G":
                    risultato = 0.015 + 0.011 * passo;
                    break;

                case "8E":
                    risultato = 0.05 + 0.011 * passo;
                    break;

                case "9G":
                    risultato = 0.015 + 0.011 * passo;
                    break;

                case "9e":
                    risultato = 0.05 + 0.011 * passo;
                    break;

                case "NO":
                    if(classeDiamMedio.Equals("4G") || classeDiamMedio.Equals("5G") || classeDiamMedio.Equals("6G") || classeDiamMedio.Equals("7G") || classeDiamMedio.Equals("8G"))
                    {
                        risultato = 0.015 + 0.011 * passo;
                    }
                    
                    break;

                case "G":
                    if (classeDiamMedio.Equals("4G") || classeDiamMedio.Equals("5G") || classeDiamMedio.Equals("6G") || classeDiamMedio.Equals("7G") || classeDiamMedio.Equals("8G"))
                    {
                        risultato = 0.015 + 0.011 * passo;
                    }
                    break;

            }

            return risultato;
        }

        public double getDiamInternoMin(double scostamento, string classeDiamMedio, string classeDiamInterno, string diamEsterno, double passo, string heliCoil, string tipologia)
        {
            double risultato = 0.0;
            scostamento = getScostamento(classeDiamInterno, classeDiamMedio, passo);

            double firstParam = double.Parse(diamEsterno, CultureInfo.InvariantCulture) * 1.082;
            double secondParam = calculateSecondParam(heliCoil, diamEsterno);
            double thirdParam = calculateThirdParam(tipologia, passo);

            string condition = classeDiamMedio;

            switch (condition)
            {
                case "4H":
                    risultato = double.Parse(diamEsterno, CultureInfo.InvariantCulture) + scostamento - firstParam + secondParam + thirdParam;
                    break;
                case "4G":
                    risultato = double.Parse(diamEsterno, CultureInfo.InvariantCulture) + scostamento - firstParam + secondParam + thirdParam;
                    break;
                case "5H":
                    risultato = double.Parse(diamEsterno, CultureInfo.InvariantCulture) + scostamento - firstParam + secondParam + thirdParam;
                    break;
                case "5G":
                    risultato = double.Parse(diamEsterno, CultureInfo.InvariantCulture) + scostamento - firstParam + secondParam + thirdParam;
                    break;
                case "6H":
                    risultato = double.Parse(diamEsterno, CultureInfo.InvariantCulture) + scostamento - firstParam + secondParam + thirdParam;
                    break;
                case "6G":
                    risultato = double.Parse(diamEsterno, CultureInfo.InvariantCulture) + scostamento - firstParam + secondParam + thirdParam;
                    break;
                case "7H":
                    if(passo <= 0.49)
                    {
                        risultato = 0.0;
                    }

                    risultato = double.Parse(diamEsterno, CultureInfo.InvariantCulture) + scostamento - firstParam + secondParam + thirdParam;
                    break;
                case "7G":
                    if (passo <= 0.49)
                    {
                        risultato = 0.0;
                    }

                    risultato = double.Parse(diamEsterno, CultureInfo.InvariantCulture) + scostamento - firstParam + secondParam + thirdParam;
                    break;
                case "8H":
                    if (passo <= 0.79)
                    {
                        risultato = 0.0;
                    }

                    risultato = double.Parse(diamEsterno, CultureInfo.InvariantCulture) + scostamento - firstParam + secondParam + thirdParam;
                    break;
                case "8G":
                    if (passo <= 0.79)
                    {
                        risultato = 0.0;
                    }

                    risultato = double.Parse(diamEsterno, CultureInfo.InvariantCulture) + scostamento - firstParam + secondParam + thirdParam;
                    break;
            }

            return risultato;
        }

        private double calculateSecondParam(string heliCoil, string diamEsterno)
        {
            double risultato = 0.0;

            if (heliCoil.Equals("NO"))
            {
                return risultato;
            }

            return risultato = double.Parse(diamEsterno, CultureInfo.InstalledUICulture) * 1.3;
            
        }

        private double calculateThirdParam(string tipologia, double passo)
        {
            double risultato = 0.0;

            if (tipologia.Equals("M"))
            {
                return risultato;
            }

            return risultato = 1.082 * passo - 0.974 * passo;
        }


    }
}
