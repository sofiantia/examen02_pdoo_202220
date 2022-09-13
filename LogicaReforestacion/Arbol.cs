

namespace LogicaReforestacion;

public class Arbol 
{
    protected string municipio;
    protected int cantidadArboles;
    protected string proveedor;
   
  
    public Arbol()
    {
        municipio = "";
        proveedor = "";
        cantidadArboles = 0;
    }

    public Arbol(string municipio, int cantidadArboles, string proveedor)
    {
        this.municipio = municipio;
        this.cantidadArboles = cantidadArboles;
        this.proveedor = proveedor;
    }

    public string Municipio
    {
        get { return municipio; }
        set { municipio = value; }
    }

    public int CantidadArboles
    {
        get { return cantidadArboles; }
        set { cantidadArboles = value; }
       
    }

    public string Proveedor
    {
        get { return proveedor; }
        set { proveedor = value; }
    }

    

    public override string ToString()
    {
        string informacion = $"Estos arboles son del municipio {municipio}\n" +
            $"sobrevivieron {cantidadArboles} y los cuida {proveedor} \n" ;

        return informacion;
    }
}

