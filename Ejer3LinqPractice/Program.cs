using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string archivo = File.ReadAllText("Heroes.json");
            List<Heroe> heroes = JsonConvert.DeserializeObject<List<Heroe>>(archivo);
            Console.WriteLine(archivo);
        }
    }
}

