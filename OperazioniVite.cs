using DRAlpha2;
using System;
using System.Windows.Forms;

public class OperazioniVite

{
    private string heliCoil;
    private double diamEsterno;
    private string classeDiamMedio;
    private double angolo;
    private string formato;
    private string passo;
    private string classeDiametroEsterno;
    private int numeroPrincipi;

    public string HeliCoil { get => heliCoil; set => heliCoil = value; }
    public double DiamEsterno { get => diamEsterno; set => diamEsterno = value; }
    public string ClasseDiamMedio { get => classeDiamMedio; set => classeDiamMedio = value; }
    public double Angolo { get => angolo; set => angolo = value; }
    public string Formato { get => formato; set => formato = value; }
    public string Passo { get => passo; set => passo = value; }



    public string ClasseDiametroEsterno { get => classeDiametroEsterno; set => classeDiametroEsterno = value; }
    public int NumeroPrincipi { get => numeroPrincipi; set => numeroPrincipi = value; }

    //prova di modifiche

    public OperazioniVite() { }

    public double GetScostamentoUno(string classeDiametroEsterno,double passo)
    {

        Double primoValore = 0.0;
        Double secondoValore = 0.0;
        if (classeDiametroEsterno.Equals("4g") || classeDiametroEsterno.Equals("5g") || classeDiametroEsterno.Equals("6g")
            || classeDiametroEsterno.Equals("7g") || classeDiametroEsterno.Equals("8g") || classeDiametroEsterno.Equals("9g"))
        {

            primoValore = 0.015 + 0.011 * passo;
        }
        else if (classeDiametroEsterno.Equals("4e") || classeDiametroEsterno.Equals("6e") || classeDiametroEsterno.Equals("7e")
          || classeDiametroEsterno.Equals("8e") || classeDiametroEsterno.Equals("9e"))
        {

            primoValore = 0.05 + 0.011 * passo;
        }

        if (classeDiametroEsterno.Equals("NO") == false && !classeDiametroEsterno.Equals("G") == false)
        {

            if (classeDiametroEsterno.Equals("4g") || classeDiametroEsterno.Equals("5g") || classeDiametroEsterno.Equals("6g")

                || classeDiametroEsterno.Equals("7g") || classeDiametroEsterno.Equals("8g") || classeDiametroEsterno.Equals("9g"))
            {

                secondoValore = 0.015 + 0.011 * passo;
            }
            else if (classeDiametroEsterno.Equals("4e") || classeDiametroEsterno.Equals("6e") || classeDiametroEsterno.Equals("7e")
          || classeDiametroEsterno.Equals("8e") || classeDiametroEsterno.Equals("9e"))
            {

                secondoValore = 0.05 + 0.011 * passo;
            }

        }

        return primoValore + secondoValore;


    }
    public double GetDiametroEsternoMax(string heliCoil, string classeDiametroMedio, double diametroEsterno, double passo, double angolo, double scostamento)
    {
        double valore = 0.0;

        if (heliCoil == "NO")
        {
            if (classeDiametroMedio.Equals("3h") || classeDiametroMedio.Equals("4h") || classeDiametroMedio.Equals("4g") || classeDiametroMedio.Equals("5h")
                || classeDiametroMedio.Equals("5g") || classeDiametroMedio.Equals("6h") || classeDiametroMedio.Equals("6g") || classeDiametroMedio.Equals("7h")
                || classeDiametroMedio.Equals("7g"))
            {

                valore = diametroEsterno - scostamento + 0.0;


            }
            else if ((classeDiametroMedio.Equals("4e") || classeDiametroMedio.Equals("6e") || classeDiametroMedio.Equals("7e") || classeDiametroMedio.Equals("8e")
              || classeDiametroMedio.Equals("9e")) && (passo <= 0.49))
            {

                valore = 0.0;
            }
            else if ((classeDiametroMedio.Equals("4e") || classeDiametroMedio.Equals("6e") || classeDiametroMedio.Equals("7e") || classeDiametroMedio.Equals("8e")
             || classeDiametroMedio.Equals("9e")) && (passo >= 0.50))
            {

                valore = diametroEsterno - scostamento + 0.0;

            }
            else if ((classeDiametroMedio.Equals("8g") || classeDiametroMedio.Equals("9g")) && (passo <= 0.79))
            {
                valore = 0.0; //0
            }
            else if ((classeDiametroMedio.Equals("8g") || classeDiametroMedio.Equals("9g")) && (passo >= 0.80))
            {
                valore = diametroEsterno - scostamento + 0.0;

            }
            return valore;
        }
        else
        { // heli coil == si

            if (classeDiametroMedio.Equals("3h") || classeDiametroMedio.Equals("4h") || classeDiametroMedio.Equals("4g") || classeDiametroMedio.Equals("5h")
                || classeDiametroMedio.Equals("5g") || classeDiametroMedio.Equals("6h") || classeDiametroMedio.Equals("6g") || classeDiametroMedio.Equals("7h")
                || classeDiametroMedio.Equals("7g"))
            {

                double calcolo = passo * (Math.Cos((angolo / 2) * (Math.PI / 180) / 8) * 6) * 2;
                valore = diametroEsterno - scostamento + calcolo;


            }
            else if ((classeDiametroMedio.Equals("4e") || classeDiametroMedio.Equals("6e") || classeDiametroMedio.Equals("7e") || classeDiametroMedio.Equals("8e")
              || classeDiametroMedio.Equals("9e")) && (passo <= 0.49))
            {

                valore = 0.0;
            }
            else if ((classeDiametroMedio.Equals("4e") || classeDiametroMedio.Equals("6e") || classeDiametroMedio.Equals("7e") || classeDiametroMedio.Equals("8e")
             || classeDiametroMedio.Equals("9e")) && (passo >= 0.50))
            {

                double calcolo = passo * (Math.Cos((angolo / 2) * (Math.PI / 180) / 8) * 6) * 2;
                valore = diametroEsterno - scostamento + calcolo;

            }
            else if ((classeDiametroMedio.Equals("8g") || classeDiametroMedio.Equals("9g")) && (passo <= 0.79))
            {
                valore = 0.0;
            }
            else if ((classeDiametroMedio.Equals("8g") || classeDiametroMedio.Equals("9g")) && (passo >= 0.80))
            {
                double calcolo = passo * (Math.Cos((angolo / 2) * (Math.PI / 180) / 8) * 6) * 2;
                valore = diametroEsterno - scostamento + calcolo;

            }
            return valore + scostamento;
        }



    }
    public double GetTolleranzaUno(string classeDiametroEsterno, double passo, string heliCoil, string classeDiametroMedio)
    {
        double risultatoUno = 0.0;
        double risultatoDue = 0.0;


        if (heliCoil.Equals("SI"))
        {

            return 0.0;
        }
        else

            if (classeDiametroEsterno.Equals("4h") || classeDiametroEsterno.Equals("4g"))
        {

            risultatoUno = ((180 * (Math.Pow(Math.Pow(passo, 2), 1 / 3))) - (3.15 / Math.Pow(passo, 1 / 2))) / 1000 * 0.63;

        }
        else if (classeDiametroEsterno.Equals("6h") || classeDiametroEsterno.Equals("6g"))
        {

            risultatoUno = ((180 * (Math.Pow(Math.Pow(passo, 2), 1 / 3))) - (3.15 / Math.Pow(passo, 1 / 2))) / 1000;

        }
        else if (classeDiametroEsterno.Equals("4e") && passo > 0.49) // da rivedere per inserirla all'interno della riga #172
        {
            risultatoUno = ((180 * (Math.Pow(Math.Pow(passo, 2), 1 / 3))) - (3.15 / Math.Pow(passo, 1 / 2))) / 1000 * 0.63;
        }


        else if (classeDiametroEsterno.Equals("6e") && passo > 0.49) // da rivedere per inserirla all'interno della riga #172
        {
            risultatoUno = ((180 * (Math.Pow(Math.Pow(passo, 2), 1 / 3))) - (3.15 / Math.Pow(passo, 1 / 2))) / 1000;
        }
        else if ((classeDiametroEsterno.Equals("8g") || classeDiametroEsterno.Equals("8e")) && passo > 0.79) // da rivedere per inserirla all'interno della riga #172
        {
            risultatoUno = ((180 * (Math.Pow(Math.Pow(passo, 2), 1 / 3))) - (3.15 / Math.Pow(passo, 1 / 2))) / 1000 * 1.6;
        }
        //calcolo secondo valore
        if (classeDiametroMedio.Equals("6g") && classeDiametroEsterno.Equals("G") || classeDiametroMedio.Equals("8g") && classeDiametroEsterno.Equals("NO") ||
            classeDiametroMedio.Equals("8e") && classeDiametroEsterno.Equals("NO"))
        {
            risultatoDue = ((180 * (Math.Pow(Math.Pow(passo, 2), 1 / 3))) - (3.15 / Math.Pow(passo, 1 / 2))) / 1000 * 1.6;
        }
        else if (classeDiametroMedio.Equals("6h") && classeDiametroEsterno.Equals("NO") || classeDiametroMedio.Equals("6g") && classeDiametroEsterno.Equals("NO") ||
            classeDiametroMedio.Equals("6e") && classeDiametroEsterno.Equals("NO"))
        {

            risultatoDue = ((180 * (Math.Pow(Math.Pow(passo, 2), 1 / 3))) - (3.15 / Math.Pow(passo, 1 / 2))) / 1000;

        }
        else if (classeDiametroMedio.Equals("4h") && classeDiametroEsterno.Equals("NO") || classeDiametroMedio.Equals("4g") && classeDiametroEsterno.Equals("NO") ||
          classeDiametroMedio.Equals("4e") && classeDiametroEsterno.Equals("NO"))
        {

            risultatoDue = ((180 * (Math.Pow(Math.Pow(passo, 2), 1 / 3))) - (3.15 / Math.Pow(passo, 1 / 2))) / 1000 * 0.6;

        }
        return risultatoUno + risultatoDue;
    }
    public double GetDiametroEsternoMin(double diametroEsternoMax, double tolleranza)
    {

        return diametroEsternoMax - tolleranza;
    }

    public double GetScostamentoDue(string heliCoil, string classeDiametroMedio, double passo) {
        double risultato = 0.0;

        if (heliCoil.Equals("SI"))
        {

            return 0.0;

        }
        else {
            if (classeDiametroMedio.Equals("4g") || classeDiametroMedio.Equals("5g") || classeDiametroMedio.Equals("6g") ||
                classeDiametroMedio.Equals("7g") || classeDiametroMedio.Equals("8g") || classeDiametroMedio.Equals("9g")) {

                risultato = 0.015 + 0.011 * passo;
            } else if (classeDiametroMedio.Equals("4e") || classeDiametroMedio.Equals("6e") || classeDiametroMedio.Equals("7e") ||
                classeDiametroMedio.Equals("8e") || classeDiametroMedio.Equals("9e")) {

                risultato = 0.05 + 0.011 * passo;
            }

        }

        return risultato;

    }


    public double GetDiametroMedioMax(string classeDiametroMedio, double passo, double scostamento, double diametroEsterno, string heliCoil, double angolo) {
        double risultato = 0.0;
        double calcolo = 0.0;
        if (heliCoil.Equals("SI"))
        {
            calcolo = passo * (Math.Cos((angolo / 2) * (Math.PI / 180) / 8) * 6) * 2;
        }

        if (classeDiametroMedio.Equals("3h") || classeDiametroMedio.Equals("4h") || classeDiametroMedio.Equals("4g") || classeDiametroMedio.Equals("5h") ||
                classeDiametroMedio.Equals("5g") || classeDiametroMedio.Equals("6h") || classeDiametroMedio.Equals("6g") || classeDiametroMedio.Equals("7h") ||
                classeDiametroMedio.Equals("7g")) {


            risultato = (diametroEsterno - (passo * (Math.Cos((angolo / 2) * (Math.PI / 180))) / 8) * 6) + calcolo - scostamento;

        } else if ((classeDiametroMedio.Equals("4e") || classeDiametroMedio.Equals("6e") || classeDiametroMedio.Equals("7e")
            || classeDiametroMedio.Equals("8e") || classeDiametroMedio.Equals("9e")) && passo <= 0.49) {

            risultato = 0.0;

        } else if ((classeDiametroMedio.Equals("4e") || classeDiametroMedio.Equals("6e") || classeDiametroMedio.Equals("7e")
              || classeDiametroMedio.Equals("8e") || classeDiametroMedio.Equals("9e")) && passo >= 0.50)
        {

            risultato = (diametroEsterno - (passo * (Math.Cos((angolo / 2) * (Math.PI / 180))) / 8) * 6) + calcolo - scostamento;
        } else if ((classeDiametroMedio.Equals("8g") || classeDiametroMedio.Equals("9g")) && passo <=0.79)
        {
            risultato = 0.0;
        } else if ((classeDiametroMedio.Equals("8g") || classeDiametroMedio.Equals("9g")) && passo >= 0.80)
        {
            risultato = (diametroEsterno - (passo * (Math.Cos((angolo / 2) * (Math.PI / 180))) / 8) * 6) + calcolo - scostamento;
        }

        return risultato;
    }

    public double GetTolleranzaDue(string heliCoil, string classeDiametroMedio, double passo, double diametroEsterno)
    {
        double risultato = 0.0;

        if (classeDiametroMedio.Equals("3h")) {
            risultato = (90 * Math.Pow(passo, 0.4) * Math.Pow(diametroEsterno, 0.1)) * 0.5 / 1000;
        
        } else if (classeDiametroMedio.Equals("4h") || classeDiametroMedio.Equals("4g"))
        {
            risultato = (90 * Math.Pow(passo, 0.4) * Math.Pow(diametroEsterno, 0.1)) * 0.63 / 1000;

        }
        else if (classeDiametroMedio.Equals("5h") || classeDiametroMedio.Equals("5g"))
        {
            risultato = (90 * Math.Pow(passo, 0.4) * Math.Pow(diametroEsterno, 0.1)) * 0.80 / 1000;

        }
        else if (classeDiametroMedio.Equals("6h") || classeDiametroMedio.Equals("6g") || classeDiametroMedio.Equals("6e"))
        {
            risultato = (90 * Math.Pow(passo, 0.4) * Math.Pow(diametroEsterno, 0.1)) / 1000;

        }
        else if (classeDiametroMedio.Equals("7h") || classeDiametroMedio.Equals("7g") || classeDiametroMedio.Equals("7e"))
        {
            risultato = (90 * Math.Pow(passo, 0.4) * Math.Pow(diametroEsterno, 0.1)) * 1.25/ 1000;

        }
        else if (classeDiametroMedio.Equals("4e") && passo > 0.49)
        {
            risultato = (90 * Math.Pow(passo, 0.4) * Math.Pow(diametroEsterno, 0.1)) / 1000 * 0.63;

        }
        else if ((classeDiametroMedio.Equals("8g") || classeDiametroMedio.Equals("8e")) && passo > 0.79)
        {
            risultato = (90 * Math.Pow(passo, 0.4) * Math.Pow(diametroEsterno, 0.1))* 1.6 / 1000;

        }
        else if ((classeDiametroMedio.Equals("9g") || classeDiametroMedio.Equals("9e")) && passo > 0.79)
        {
            risultato = (90 * Math.Pow(passo, 0.4) * Math.Pow(diametroEsterno, 0.1)) * 2 / 1000;

        }

        return risultato;


    }
    public double GetDiametroMedioMin(string heliCoil, double diametroMedioMax, double tolleranza) { 
    
        if (heliCoil.Equals("NO"))
        {
            return diametroMedioMax - tolleranza;
        } else
        {
            return diametroMedioMax + tolleranza;
        }
    
    }

    public double GetDiametroNoccMax( string formato, double diametroEsternoMax, double passo)
    {
        if (formato.Equals("M"))
        {
            return (diametroEsternoMax - (passo * 1.082) - GetRaggioFondoMin(formato,passo));
        } else
        {
            return (diametroEsternoMax - (passo * 0.974) - GetRaggioFondoMin(formato,passo));
        }
    }

    public double GetTolleranzaTre(string heliCoil, double diametroNoccMax, double tolleranzaDue, double passo, string formato)
    {
        if (heliCoil.Equals("NO"))
        {
            return diametroNoccMax - (diametroNoccMax - tolleranzaDue - GetRaggioFondoMin(formato, passo));
        } else
        {
            return tolleranzaDue;
        }
    }

    public double GetDiametroNoccMin(string heliCoil, double diametroNoccMax, double tolleranzaDue,double tolleranzaTre, double passo, string formato)
    {

        if (heliCoil.Equals("NO"))
        {
            return diametroNoccMax - tolleranzaDue - GetRaggioFondoMin(formato,passo);
        }
        else
        {
            return diametroNoccMax + tolleranzaTre;
        }
    }

    public double GetRaggioFondoMin(string formato, double passo)
    {

        if (formato.Equals("M")) {

            return passo * 0.10825;
        } else
        {
            return passo * 0.15011;
        }
    }

    public double GetRaggioFondoMax(string formato, double passo)
    {
         if (formato.Equals("M"))
        {

            return passo * 0.14434;
        }
        else
        {
            return passo * 0.18042;
        }
    }
    
}

