using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Adatok> lista = new List<Adatok>();
            using (StreamReader sr = new StreamReader("C:\\Users\\tanulo\\Desktop\\Kiss Dániel\\felfedezesek.csv")) { 
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    Adatok sor1 = new Adatok(sor);
                    lista.Add(sor1);
                }
                Console.WriteLine("3. feladat: Elemek száma: "+lista.Count());
                int okor = 0; 
                foreach (var évek in lista.Where(x=>x.év=="Ókor"))
                {
                    okor++;
                }
                Console.WriteLine("4. feladat: Felfedezések száma az ókorban: "+okor);
                string bekert;
                do
                {
                    Console.WriteLine("5. feladat: Kérek egy vegyjelet!: ");
                    bekert = Console.ReadLine();
                } while (bekert.Length > 2);





                if (lista.Exists(x=>x.vegyjel==bekert.ToLower()))
                {
                    Console.WriteLine("6. feladat: Keresés");
                    foreach (var elemek in lista.Where(x=>x.vegyjel==bekert.ToLower()))
                    {
                        Console.WriteLine($"\tAz elem vegyjele: {elemek.vegyjel}");
                        Console.WriteLine($"\tAz elem neve: {elemek.név}");
                        Console.WriteLine($"\tRendszáma: {elemek.rendszam}");
                        Console.WriteLine($"\tFelfedezés éve: {elemek.év}");
                        Console.WriteLine($"\tFelfedező: {elemek.felfedezo}");
                    }
                }
                else
                {
                    Console.WriteLine("Nincs ilyen elem az adatforrásban!");
                }

                foreach (var evek in lista.Where(x=>x.év!="Ókor"))
                {

                }

                


            }

        }
    }
}
