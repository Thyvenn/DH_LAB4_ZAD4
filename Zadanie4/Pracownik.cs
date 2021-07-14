using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    // .. Następnie stwórz dwie klasy dziedziczące z Osoby - Klient i Pracownik.
    public class Pracownik : Osoba
    {
        // Pracownik powinien mieć DatęZatrudnienia i (null'owalną) DatęZwolnienia.
        public DateTime DataZatrudnienia { get; set; }

        // ? załatwia strawę NOT NULL-a
        public DateTime? DataZwolnienia { get; set; }
    }
}
