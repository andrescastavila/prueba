using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRUEBA.Models
{
    public class Discos
    {
        public Discos(int discoid, string titulo, int anyo, string grupo)
        {
            Discoid = discoid;
            Titulo = titulo;
            Anyo = anyo;
            Grupo = grupo;
        }

        public int Discoid { get; set; }
        public string Titulo { get; set; }
        public int Anyo { get; set; }
        public string Grupo { get; set; }


    }

}