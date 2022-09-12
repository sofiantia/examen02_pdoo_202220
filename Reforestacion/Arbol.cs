

namespace LogicaReforestacion;

public class Arbol 
{
    protected string municipio;
    protected int cantidad;
    protected bool cp;
    //El bool es para determinar si fueron plantados por la comunidad o un proveedor privado

  
    public Arbol()
    {
        municipio = "";
        cantidad = 0;
        cp = false;

    }

    public Arbol(string municipio, int cantidad, bool cp)
    {
        this.municipio = municipio;
        this.cantidad = cantidad;
        this.cp = cp;
    }

    public string Municipio
    {
        get { return municipio; }
        set { municipio = value; }
    }

    public int Cantidad
    {
        get { return cantidad; }
        set { cantidad = value; }
       
    }

    public bool CP
    {
        get { return cp; }
        set { cp = value; }
    }
}

