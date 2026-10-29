using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton2a
{
    public sealed class  Drukarka
    {
        private static readonly Drukarka _instancja = new Drukarka();
        private Drukarka() {
            Console.WriteLine("Utworzono drukarkę");
         }
        public static Drukarka PobierzInstancje()
        {
            return _instancja;
        }
        public void Drukuj(string tekst)
        {
            Console.WriteLine($"Drukuję: {tekst}");
        }
    }
}
