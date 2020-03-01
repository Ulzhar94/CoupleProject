using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRAlpha2
{
    public class OperazioniMadreVite
    {
    
        public double getScostamento(string classeDiamMedio, float passo)
        {
            double risultato = 0.0;
            string condition = classeDiamMedio;

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
                    
                    break;

                case "G":
                    
                    break;

            }


            return risultato;
        }


    }
}
