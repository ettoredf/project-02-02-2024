using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_02_02_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contribuente contribuente = new Contribuente();

            // inserimento dati contribuente
            Console.Write("Inserisci il nome: ");
            contribuente.Nome = Console.ReadLine();

            Console.Write("Inserisci il cognome: ");
            contribuente.Cognome = Console.ReadLine();

            Console.Write("Inserisci la data di nascita (formato YYYY-MM-DD): ");
            contribuente.DataNascita = DateTime.Parse(Console.ReadLine());

            Console.Write("Inserisci il codice fiscale: ");
            contribuente.CodiceFiscale = Console.ReadLine();

            Console.Write("Inserisci il sesso (M/F): ");
            contribuente.Sesso = char.Parse(Console.ReadLine());

            Console.Write("Inserisci il comune di residenza: ");
            contribuente.ComuneResidenza = Console.ReadLine();

            Console.Write("Inserisci il reddito annuale: ");
            contribuente.RedditoAnnuale = double.Parse(Console.ReadLine());

            // calcolo imposta
            double imposta = contribuente.CalcoloImposta();

            // riepilogo
            Console.WriteLine("==================================================");

            Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:");

            Console.WriteLine("\nRiepilogo Contribuente:");
            Console.WriteLine($"Nome: {contribuente.Nome}");
            Console.WriteLine($"Cognome: {contribuente.Cognome}");
            Console.WriteLine($"Data di nascita: {contribuente.DataNascita.ToShortDateString()} ({contribuente.Sesso})");
            Console.WriteLine($"Codice Fiscale: {contribuente.CodiceFiscale}");
            Console.WriteLine($"Comune di residenza: {contribuente.ComuneResidenza}");
            Console.WriteLine($"Reddito annuale:  {contribuente.RedditoAnnuale:C}");
            Console.WriteLine($"Imposta da pagare:  {imposta:C}");
            Console.ReadLine();
        }
    }
}
