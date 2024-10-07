using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Triatlon
{
    internal class Versenyzo
    {
        public string? nev { get; set; }
        public int szulev { get; set; }
        public int kor => DateTime.Now.Year - szulev;
        public int rajtszam { get; set; }

        //public bool nem { get; set; }
        public string? nem { get; set; }

        public string? csoportositas { get; set; }
        public TimeSpan uszasideje { get; set; }
        public TimeSpan elsodepo { get; set; }
        public TimeSpan kerekparideje { get; set; }
        public TimeSpan masodikdepo { get; set; }
        public TimeSpan futasideje { get; set; }
        public TimeSpan osszido => uszasideje + elsodepo + kerekparideje + masodikdepo + futasideje;

        public override string ToString()
        {
         return $"Versenyző neve: {nev}\n" +
                $"Születési éve: {szulev}\n" +
                $"Rajtszáma: {rajtszam}\n" +
                $"Neme: {/*(nem ? "férfi" : "nő")*/ nem}\n" +
                $"Kategóriája: {csoportositas}\n" +
                $"Időeredmények:" + $"\n" +
                $"Úszás ideje: {uszasideje}\n" +
                $"Első depóban töltött idő: {elsodepo}\n" +
                $"Kerékpározás ideje: {kerekparideje}" + $"\n" +
                $"Második depóban töltött idő: {masodikdepo}\n" +
                $"Futás ideje: {futasideje}";
        }
    }
}
