using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftAcademy_Esercizio8
{
    class Menu
    {
        public static void Start()
        {
            Console.WriteLine("Benvenuto!");
            char continua;

            do
            {
                Console.WriteLine("\n ");
                Console.WriteLine("Scegli l'azione da eseguire: ");
                Console.WriteLine("1) Aggiungi un libro");
                Console.WriteLine("2) Elimina un libro");
                Console.WriteLine("3) Visualizzare tutti i libri");
                Console.WriteLine("4) Filtra per genere");

                int num;
                while (!int.TryParse(Console.ReadLine(), out num) || num <1 || num >4)
                {
                    Console.WriteLine("Inserire valore corretto!");
                }

                switch (num)
                {
                    case 1:
                        Magazzino.AggiungiLibro();
                        break;

                    case 2:
                        Magazzino.EliminaLibro();
                        break;

                    case 3:
                        Magazzino.VisualizzaLibri();
                        break;

                    case 4: Magazzino.FiltraLibri();
                        break;

                    default:
                        break;


                }


                Console.WriteLine("\nSe vuoi continuare, digita s");
                continua = Console.ReadKey().KeyChar;



            } while (continua == 's' || continua == 'S');
        }
    }
    }

