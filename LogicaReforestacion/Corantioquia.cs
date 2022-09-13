
using LogicaReforestacion;

namespace Reforestacion

{
    public class Corantioquia
    {
        private Arbol[] LosArboles;
        private int arbolesSembrados;
        private float porcentajeSobreviviente;
        private int personasAsignadas;
        private int galonesAgua, galonesagUa;
        private int arbolesSobrevivientes;
        private bool exitoso;
        

        public Corantioquia()
        {

            LosArboles = new Arbol[100];
            arbolesSembrados = 1000;
            personasAsignadas = 0;
            galonesAgua = 0;
            galonesagUa = 0;
            arbolesSobrevivientes = 0;
            porcentajeSobreviviente = 0;
            exitoso = false;

            RecepcionArboles();
        }

        Random aleatorio = new Random();

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

        public int galonesagua
        {
            get { return galonesagUa; }
        }

        public int GalonesAgua
        {
            get { return galonesAgua; }
        }

        public int ArbolesSobrevivientes
        {
            get { return arbolesSobrevivientes; }
        }

        public float PorcentajeSobrevivente
        {
            get { return porcentajeSobreviviente; }
        }

        public bool Exitoso
        {
            get { return exitoso; }
        }

        public void RecepcionArboles()
        {
            
            

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
                    LosArboles[i].CantidadArboles = aleatorio.Next(1, 1001);
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
                        $"dedican {galonesAgua} galones de agua.");

                    
                }
                porcentajeSobreviviente = (float)LosArboles[i].CantidadArboles / arbolesSembrados * 100;
                Console.WriteLine($"Porcentaje de supervivencia: {porcentajeSobreviviente}%");

                if (porcentajeSobreviviente >= 70)
                    Console.WriteLine("El proceso de reforestacion fue exitoso");
                else
                    Console.WriteLine("El proceso de reforestacion no fue satisfactorio");

            }

           


        }

        public void CalculaLitros()
        {
            for (int i = 0; i < LosArboles.Length; i++)
            {
                foreach (Arbol unArbol in LosArboles)
                {
                    if (unArbol.Proveedor == "Privado")
                        galonesagUa = LosArboles[i].CantidadArboles * 10;
                    else
                        personasAsignadas = aleatorio.Next(5, 51);
                }
            }
           
        }

        public void DeterminaExito()
        {
            exitoso = false;
            for (int i = 0; i < LosArboles.Length; i++)
            {
                

                foreach (Arbol unArbol in LosArboles)
                {
              
                    if (LosArboles[i].CantidadArboles >= 700)
                        exitoso = true;
                    else
                       exitoso = false;
                }
            }

        }

        public void CalculaPorcentaje()
        {
            porcentajeSobreviviente = 0;
            arbolesSembrados = 1000;
            for (int i = 0; i < LosArboles.Length; i++)
            {
              
                foreach (Arbol unArbol in LosArboles)
                {
                    porcentajeSobreviviente = (float)LosArboles[i].CantidadArboles / arbolesSembrados * 100;
                }
            }

        }

}   }


