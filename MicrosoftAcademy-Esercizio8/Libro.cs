using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftAcademy_Esercizio8
{
    class Libro

    {
        public string CodiceISBN { get; set; }
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public ElencoGen Genere { get; set; }
        public decimal Prezzo { get; set; }

        public enum ElencoGen
        {
            GIALLO,
            THRILLER,
            FANTASY,
            BIOGRAFIA,
            ROMANZO_STORICO,
    

        }

        public Libro() {      //costruttore

            this.CodiceISBN = CodiceISBN;
            this.Titolo = Titolo;
            this.Autore = Autore;
            this.Genere = Genere;
            this.Prezzo = Prezzo;

        }

    }
}
