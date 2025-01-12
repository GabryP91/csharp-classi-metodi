/*
    1. Creare una classe Quadrato, che dichiari la variabile intera lato e due metodi per calcolare
    perimetro e area. All’interno della classe che contiene il metodo Main istanziare più oggetti di
    tipo Quadrato per fare degli esempi.

    2. Per gestire un’agenzia di viaggi creare una classe Viaggio, con gli attributi nome della località,
    durata viaggio e costo. Creare un metodo per stampare a video le informazioni sul viaggio e altri
    due metodi a piacere.

    3. Scrivere un metodo che, presi come parametri un nome ed un cognome, stampi entrambi a
    schermo utilizzando l’interpolazione di stringhe.

    4. Creare un metodo che serve ad effettuare la conversione di un intero in un double.

    5. Scrivere un metodo SommaApprossimata che prende due numeri con la virgola, li somma e poi
    stampa il risultato come numero intero.

    6. Scrivere i metodi per calcolare e visualizzare la somma, la media, il prodotto di 3 numeri interi. 

*/

using System;
using System.Globalization;

namespace csharp_classi_metodi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Cultura corrente: {CultureInfo.CurrentCulture}");
            Console.WriteLine($"UI Cultura corrente: {CultureInfo.CurrentUICulture}");
           

            // ESERCIZIO 1
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 1\n");
            Quadrato q1 = new Quadrato(5);
            Console.WriteLine($"Quadrato 1: Lato = {q1.Lato}, Perimetro = {q1.CalcolaPerimetro()}, Area = {q1.CalcolaArea()}");

            Quadrato q2 = new Quadrato(13);
            Console.WriteLine($"Quadrato 2: Lato = {q2.Lato}, Perimetro = {q2.CalcolaPerimetro()}, Area = {q2.CalcolaArea()}");

            // ESERCIZIO 2
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 2\n");

            Viaggio prova = new Viaggio("Parigi", 5, 33.267896);

            prova.StampaInformazioni();


            Console.WriteLine("\nIl Costo medio giornaliero prima:{0}", prova.CalcolaCostoMedioGiornaliero());

            prova.CostoViaggio();

            Console.WriteLine("\nIl Costo medio giornaliero poi:{0}", prova.CalcolaCostoMedioGiornaliero());

            // ESERCIZIO 3
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 3\n");

            StampaNomeCompleto("Mario", "Rossi");

            // ESERCIZIO 4
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 4\n");

            Console.WriteLine("Il valore int è 5 che convertito in double sarà:{0}", ConverIntToDouble(5));

            // ESERCIZIO 5
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 5\n");

            Console.WriteLine("La somma di 12.54673447 e 23.56789321 sarà:{0}", SommaApprossimata(12.54673447, 23.56789321));

            // ESERCIZIO 6
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 6\n");

            int x = 3, y = 4, z = 5;

            Console.WriteLine($"Somma: {Somma(x, y, z)}");
            Console.WriteLine($"Media: {Media(x, y, z)}");
            Console.WriteLine($"Prodotto: {Prodotto(x, y, z)}");


        }

        static void StampaNomeCompleto(string nome, string cognome)
        {
            Console.WriteLine($"Nome completo: {nome} {cognome}");
        }

        static double ConverIntToDouble(int valore)
        {

            double res = 0;

            //ritorno valore double tramite conversione implicita
            return res = valore;
        }

        static int SommaApprossimata(double numero1, double numero2)
        {
            double somma = numero1 + numero2;

            return (int) somma; 
      
        }

        static int Somma(int a, int b, int c)
        {
            return a + b + c;
        }

        static double Media(int a, int b, int c)
        {
            return Somma(a, b, c) / 3.0;
        }

        static int Prodotto(int a, int b, int c)
        {
            return a * b * c;
        }
    }


    public class Quadrato
    {
        public int Lato;

        // Costruttore parametrizzato
        public Quadrato(int lato)
        {
            this.Lato = lato;
        }

        public int CalcolaPerimetro()
        {
            return 4 * Lato;
        }

        public int CalcolaArea()
        {
            return Lato * Lato;
        }
    }

    public class Viaggio
    {
        public string Località;
        public int Durata; // in giorni
        public double Costo;

        // Costruttore parametrizzato
        public Viaggio(string località, int durata, double costo)
        {
            this.Località = località;
            this.Durata = durata;
            this.Costo = costo;
        }


        //funzione Calcolo costo
        public void CostoViaggio()
        {
            double costo = 0;
            int durata;

            //Controllo input utente
            Console.WriteLine("\nInserisci un numero intero");
            while (!int.TryParse(Console.ReadLine(), out durata))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero intero");
            }

            this.Durata = durata;

            //Controllo input utente
            Console.WriteLine("\nInserisci il costo come intero o con la virgola");
            while (!double.TryParse(Console.ReadLine(), out costo))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            this.Costo = costo;

            Console.WriteLine("\nIl nuovo Viaggio avrà i seguenti valori\n");

            StampaInformazioni();

        }

        public double CalcolaCostoMedioGiornaliero()
        {
            return Costo / Durata;
        }

        public void StampaInformazioni()
        {
            Console.WriteLine($"Viaggio a {Località}, Durata: {Durata} giorni, Costo: {Costo} euro");
        }
    }
}
