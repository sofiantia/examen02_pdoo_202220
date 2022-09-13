using System;
using LogicaReforestacion;
namespace Reforestacion
{
    public class Corantioquia
    {
        private Arbol[] LosArboles;
        private int arbolesSembrados;
        private float porcentajeSobreviviente;
        private int personasAsignadas;
        private int galonesAgua;
        private int arbolesSobrevivientes;
        

        public Corantioquia()
        {

            LosArboles = new Arbol[100];
            arbolesSembrados = 1000;
            personasAsignadas = 0;
            galonesAgua = 0;
            arbolesSobrevivientes = 0;
            porcentajeSobreviviente = 0;

            RecepcionArboles();
        }



        public Corantioquia(Arbol[] arregloArboles)
        {
            LosArboles = arregloArboles;
           
            


            personasAsignadas = 0;
            galonesAgua = 0;
            arbolesSobrevivientes = 0;
            porcentajeSobreviviente = 0;
         
        }

        public int PersonasAsignadas
        {
            get { return personasAsignadas; }
        }

        public int GalonesAgua
        {
            get { return galonesAgua; }
        }

        public int ArbolesSobrevivientes
        {
            get { return arbolesSobrevivientes; }
        }

        public float PorcentajeSobrevivencia
        {
            get { return (arbolesSobrevivientes / arbolesSembrados) * 100; }
        }

        public void RecepcionArboles()
        {
            Random aleatorio = new Random();
            

            string[] proveedor = { "Comunidad", "Privado" };
            string elProveedor;
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

            for (int i = 0; i < LosArboles.Length; i++)
            {
                elProveedor = proveedor[aleatorio.Next(proveedor.Length)];
                arbolesSembrados = 1000;

                if (elProveedor == "Comunidad")
                {
                    LosArboles[i] = new Arbol();
                    LosArboles[i].CantidadArboles = aleatorio.Next(0,1001) ;
                    LosArboles[i].Proveedor = "Comunidad";
                  
                    Console.WriteLine($"En el municipio {municipios[i]} se plantarón 1000 arboles " +
                        $"y sobrevivieron {LosArboles[i].CantidadArboles} y son cuidados por la comunidad, son cuidados por" +
                        $" {aleatorio.Next(5,51)} personas");
                }

                else
                {
                    LosArboles[i] = new Arbol()
                    {
                        Municipio = municipios[i],
                        CantidadArboles = aleatorio.Next(1, 1001),
                        Proveedor = "Proveedor privado",
                    };
                    galonesAgua = LosArboles[i].CantidadArboles * 10;
                    Console.WriteLine($"En el municipio {municipios[i]} se plantarón 1000 arboles " +
                        $"y sobrevivieron {LosArboles[i].CantidadArboles} y son cuidados por un proveedor privado, " +
                        $"dedican {GalonesAgua} galones de agua.");

                    
                }
                porcentajeSobreviviente = (float)LosArboles[i].CantidadArboles / arbolesSembrados * 100;
                Console.WriteLine($"Porcentaje de supervivencia: {porcentajeSobreviviente}%");

                if (porcentajeSobreviviente >= 70)
                    Console.WriteLine("El proceso de reforestacion fue exitoso");
                else
                    Console.WriteLine("El proceso de reforestacion no fue satisfactorio");

            }

        }
 
}   }

