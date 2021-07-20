using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MicrosoftAcademy_Esercizio8.Libro;

namespace MicrosoftAcademy_Esercizio8
{
    class Magazzino
    {

        static List<Libro> libri = new List<Libro>();

        public static void AggiungiLibro()
        {

            Libro libro = new Libro();
           
            string isbn = "", titolo = "", autore = "";
            do
            {
                Console.WriteLine("\nInserisci il codice ISBN (10 cifre)");
                isbn = Console.ReadLine().ToUpper();
            }
            while (isbn.Length != 10);


        
            Libro bookToFind = Magazzino.GetByIsbn(isbn);
        
            if (bookToFind == null)
            {
                libro.CodiceISBN = isbn;


                do
                {
                    Console.WriteLine("\nInserisci il titolo: ");
                    libro.Titolo = Console.ReadLine().ToUpper();
                } while (titolo.Length != 0);


                do
                {
                    Console.WriteLine("\nInserisci l'autore: ");
                    libro.Autore = Console.ReadLine().ToUpper();
                } while (autore.Length != 0);

                Console.WriteLine("\nInserisci il genere: ");
                libro.Genere = InserisciGenere();

                Console.WriteLine("\nInserisci il prezzo: ");
                libro.Prezzo = InserisciPrezzo();


                libri.Add(libro);

            }
            else
            {
                Console.WriteLine("\nEsiste già un libro con questo codice ISBN");
            }




        }

        private static Libro GetByIsbn(string isbn)
        {
           foreach(Libro libro in libri)
            {
                if (libro.CodiceISBN == isbn)
                {
                    return libro;
                }

            }
            return null;
        }

        private static decimal InserisciPrezzo()
        {
            decimal prezzo;
            while (!decimal.TryParse(Console.ReadLine(), out prezzo) || prezzo<0)
            {

                Console.WriteLine("\nInserisci un valore valido");

            }
            return prezzo;
        }

  

        internal static void VisualizzaLibri(List<Libro> libri)
        {
          
       
            foreach (Libro libro in libri)
            {
                Console.WriteLine($"Codice ISBN: {libro.CodiceISBN}\t" +
                                  $"Titolo: {libro.Titolo}\t " +
                                  $"Autore: {libro.Autore}\t " +
                                  $"Genere: {libro.Genere}\t " +
                                  $"Prezzo: {libro.Prezzo}");
            }
        }

        public static void VisualizzaLibri()
        {
            VisualizzaLibri(libri);
        }


        public static void FiltraLibri()
        {
            Console.WriteLine("\nScegli il genere di libri che vuoi vedere: ");

            ElencoGen genereDaFiltrare = InserisciGenere();

            List<Libro> libriPerGenere = new List<Libro>();

            foreach (Libro libro in libri)
            {
                if (libro.Genere == genereDaFiltrare)
                {
                    libriPerGenere.Add(libro);
                }
            }

            if (libriPerGenere.Count > 0)
            {
                VisualizzaLibri(libriPerGenere);
            }
            else
            {
                Console.WriteLine($"\nNon sono presenti libri del genere {genereDaFiltrare}");
            }
        }




        internal static void EliminaLibro()
        {
            Console.WriteLine("Inserisci il titolo del libro da eliminare");
            string titolo = Console.ReadLine().ToUpper();

            List<Libro> libriDaEliminare = TrovaLibroPerTitolo(titolo);
            if(libriDaEliminare.Count > 0)
            {
                libri.Remove(libriDaEliminare[0]);

                Console.WriteLine("\nAdesso la libreria è la seguente: \n");
                VisualizzaLibri();
                
            }
            else
            {
                Console.WriteLine("\nAttenzione! Questo libro non è presente in libreria. \n");
            }
       
        }       
        
        public static List<Libro> TrovaLibroPerTitolo(string titolo)
        {
            List<Libro> libriPerTitolo = new List<Libro>();

            foreach (Libro libro in libri)
            {
                if (libro.Titolo == titolo)
                {
                    libriPerTitolo.Add(libro);
                }
            }
            return libriPerTitolo;
        }

        private static Libro.ElencoGen InserisciGenere()
        {
            {
                int genere = 0;

                Console.WriteLine($"Inserisci 0 per il genere {ElencoGen.GIALLO}");
                Console.WriteLine($"Inserisci 1 per il genere {ElencoGen.THRILLER}");
                Console.WriteLine($"Inserisci 2 per il genere {ElencoGen.FANTASY}");
                Console.WriteLine($"Inserisci 3 per il genere {ElencoGen.BIOGRAFIA}");
                Console.WriteLine($"Inserisci 4 per il genere {ElencoGen.ROMANZO_STORICO}");

                while (!int.TryParse(Console.ReadLine(), out genere) || genere < 0 || genere > 4)
                {
                    Console.WriteLine("\nPuoi inserire solo numeri interi compresi tra 1 e 4");
                }

               

                return (ElencoGen)genere;
            }
        }
    }
}