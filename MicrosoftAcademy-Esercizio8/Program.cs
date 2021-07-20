/*
 Un libro è un'entità che ha

•Codice ISBN

•Titolo

•Autore

•Genere

•Prezzo

•

Per il genere usare un enum.



L’utente utilizzatore(magazziniere) può:

•inserire un nuovo libro (verificando, tramite il codice ISBN, che non ci sia già)

•eliminare un libro

•visualizzare tutti i libri

•visualizzare  i libri per genere 
    */
    

using System;

namespace MicrosoftAcademy_Esercizio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.Start();

        }
    }
}