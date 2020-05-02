using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Skripti poikkeaman etsintään. Summa luvut JSON muodossa olevasta tekstitiedostosta ja tulostaa listan summista.
/// </summary>
namespace Tracking_game_002
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rivit = File.ReadAllLines(@"LISÄÄ TIEDOSTO");
            int valiSumma = 0;
            List<int> summat = new List<int>();
            foreach(string rivi in rivit)
            {
                int numero = 0;
                bool onkoNumero = int.TryParse(rivi, out numero);
                if (onkoNumero)
                {
                    valiSumma += numero;
                }
                else
                {
                    if (valiSumma != 0) summat.Add(valiSumma);
                    valiSumma = 0;
                } 
            }
            int jarjestys = 1;
            foreach (int summa in summat)
            {
                Console.WriteLine(summa + " " + jarjestys);
                jarjestys++;
            }
            Console.ReadKey();
        }
    }
}
