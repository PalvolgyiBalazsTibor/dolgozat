using Triatlon;

List<Versenyzo> versenyzok = new List<Versenyzo>();

using StreamReader sr = new("forras.txt"); 

while (!sr.EndOfStream)
{
    string[] sor = sr.ReadLine().Split(";");

    Versenyzo versenyzo = new Versenyzo();

    versenyzo.nev = sor[0];
    versenyzo.szulev = int.Parse(sor[1]);
    versenyzo.rajtszam = int.Parse(sor[2]);
    versenyzo.nem = sor[3];
    versenyzo.csoportositas = sor[4];
    versenyzo.uszasideje = TimeSpan.Parse(sor[5]);
    versenyzo.elsodepo = TimeSpan.Parse(sor[6]);
    versenyzo.kerekparideje = TimeSpan.Parse(sor[7]);
    versenyzo.masodikdepo = TimeSpan.Parse(sor[8]);
    versenyzo.futasideje = TimeSpan.Parse(sor[9]);

    versenyzok.Add(versenyzo);
}
sr.Close();

//versenyzők száma 'elit junior' kategóriában
Console.WriteLine($"Versenyzők száma: {versenyzok.Count} darab");

//férfi versenyzők átlagéletkora
double ferfiatlagkor = versenyzok.Where(a => a.nem == "f").Average(a => a.kor);
Console.WriteLine($"A férfi versenyzők átlag átlagéletkora: {ferfiatlagkor:0.00} év");

//a versenyzők futással töltött összideje órában. 2tj-ig kerekítve
double futassaltoltottido = versenyzok.Sum(b => b.futasideje.TotalHours);
Console.WriteLine($"A versenyzők futással töltött összideje órában: {futassaltoltottido:0.00} óra");

//átlagos úszási idő 20-24 kategóriában
double atlaguszas2024 = versenyzok.Where(c => c.csoportositas == "20-24").Average(c => c.uszasideje.TotalMinutes);
Console.WriteLine($"Az átlagos úszási idő 20-24 kategóriában: {atlaguszas2024:0.00} perc");