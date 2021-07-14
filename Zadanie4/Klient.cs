using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    // .. Następnie stwórz dwie klasy dziedziczące z Osoby - Klient i Pracownik.
    public class Klient : Osoba
    {

        // Klient powinien posiadać pola NrTelefonu i NrRejestracyjny(pojazdu).
        public int NrTelefonu { get; set; }
        public string NrRejestracyjny { get; set; }

    }
}
