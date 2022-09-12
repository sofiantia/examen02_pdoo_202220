using System;
using LogicaReforestacion;

namespace Reforestacion
{
    public class program
    {
        static void Main(string[] args)
        {

            Random aleatorio = new Random();
            string[] municipios = { "Medellín",
                "Barbosa",
                "Girardota",
                "Cobacabana",
                "Bello",
                "Itagui",
                "Sabaneta",
                "Envigado",
                "La Estrella",
                "Caldas" };

            int[] cantidad = { aleatorio.Next(0, 1001) };

            bool[] cp = { aleatorio.Next(2) == 1 };
            string[] proveedor = { "La Comunidad", "Proveedor privado" };


            Corantioquia micorantioquia = new Corantioquia(new Arbol[municipios.Length], municipios, cantidad, cp);

            Arbol[] Arboles = new Arbol[municipios.Length];
            for (int i = 0; i < Arboles.Length; i++)
            {
                Arboles[i] = new Arbol();
                Arboles[i].Municipio = municipios[i];
                Arboles[i].Cantidad = aleatorio.Next(1, 1001);
                Arboles[i].CP = aleatorio.Next(2) == 1;

                if (Arboles[i].CP == false)
                    Console.WriteLine($"el municipio {municipios[i]} plantó 1000 arboles pero sobrevivieron " +
                        $"{Arboles[i].Cantidad} y el proveedor es {proveedor[0]}," +
                        $" porcentaje sobrevivencia: %");
                else
                    Console.WriteLine($"el municipio {municipios[i]} plantó 1000 arboles pero sobrevivieron " +
                        $"{Arboles[i].Cantidad} y el proveedor es {proveedor[1]}" +
                        $" porcentaje sobrevivencia: % ");



            }
        }
    }
}