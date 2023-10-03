using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apuestas.BE
{
    public class Partido
    {
        public int GolesLocal { get; set; }
        public int GolesVisitante { get; set; }
        public string Resultado { get; set; }

        public void GenerarResultado(Random random)
        {
            GolesLocal = random.Next(0, 6);
            GolesVisitante = random.Next(0, 6);
        }
        //Recibe el resultado al azar y asigna el resultado correspondiente
        public void AsignarGanador()
        {
            if (GolesLocal > GolesVisitante)
            {
                Resultado = "Local";
            }
            else if (GolesLocal < GolesVisitante)
            {
                Resultado = "Visitante";
            }
            else
            {
                Resultado = "Empate";
            }
        }
    }

}
