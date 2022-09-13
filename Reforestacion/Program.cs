using System;
using LogicaReforestacion;

namespace Reforestacion
{
    public class program
    {
        static void Main(string[] args)
        {
            string[] municipios =
            {
                "Medellín",
                "Barbosa",
                "Girardota",
                "Cobacabana",
                "Bello",
                "Itagui",
                "Sabaneta",
                "Envigado",
                "La Estrella",
                "Caldas"
            };
            
            Corantioquia micorantioquia = new Corantioquia(new Arbol[municipios.Length]);

            micorantioquia.RecepcionArboles();
            

     
        }
    }
}