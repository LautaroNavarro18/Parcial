using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cancion
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int DuracionSegundos { get; set; }

        public int ArtistaId { get; set; }
        public Artista Artista { get; set; }
    }
}
