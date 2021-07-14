using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Przygotuj dwa konteksty - z zastosowaniem TPH ...
            var thpctx = new TPHContext();
            thpctx.Database.EnsureCreated();

            // Dodaj do obu kontekstów kilka osób.
            thpctx.Add(new Klient() { Imie = "Frodo", Nazwisko = "Bagins", NrRejestracyjny = "SHR2980", NrTelefonu = 32143019 });
            thpctx.Add(new Klient() { Imie = "Aragorn", Nazwisko = "Elessar", NrRejestracyjny = "GON3019", NrTelefonu = 53203210 });
            thpctx.Add(new Klient() { Imie = "William", Nazwisko = "Adama", NrRejestracyjny = "BSG40000", NrTelefonu = 450315243 });
            thpctx.Add(new Pracownik() { Imie = "Anakin", Nazwisko = "Skywalker", DataZatrudnienia = DateTime.Now });
            thpctx.SaveChanges();

            // ... i z zastosowaniem TPT
            var tptctx = new TPTContext();
            tptctx.Database.EnsureCreated();

            // Dodaj do obu kontekstów kilka osób.
            tptctx.Add(new Klient() { Imie = "Frodo", Nazwisko = "Bagins", NrRejestracyjny = "SHR2980", NrTelefonu = 32143019 });
            tptctx.Add(new Klient() { Imie = "Aragorn", Nazwisko = "Elessar", NrRejestracyjny = "GON3019", NrTelefonu = 53203210 });
            tptctx.Add(new Klient() { Imie = "William", Nazwisko = "Adama", NrRejestracyjny = "BSG40000", NrTelefonu = 450315243 });
            tptctx.Add(new Pracownik() { Imie = "Anakin", Nazwisko = "Skywalker", DataZatrudnienia = DateTime.Now });
            tptctx.SaveChanges();
        }
    }
}
