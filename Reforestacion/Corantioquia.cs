using System;
using LogicaReforestacion;
namespace Reforestacion
{
    public class Corantioquia
    {
        Random aleatorio = new Random();
        private Arbol[] LosArboles;
        private int arbolesSembrados;
        private float[] porcentajeSobrevivencia;
        private int PersonasAsignadas;
        private int GalonesAgua;
        private int[] arbolesSobrevivientes;

        public Corantioquia()
        {

            LosArboles = new Arbol[10];
            arbolesSembrados = 1000;
            
            
            PersonasAsignadas = 0;
            GalonesAgua = 0;


        }

       
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

        

        public void CalculaPorcentaje()
        {
           
            

            
            

            
        }

        public Corantioquia(Arbol[] arregloArboles, string[] mUnicipios, int[] cAntidad, bool[] cP)
        {

        }
    }
}

