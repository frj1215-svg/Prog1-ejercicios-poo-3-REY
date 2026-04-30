namespace EjerciciosPOO3.Ejercicio02;

public class Cafe:Bebida
{
    public bool TieneLeche {get;set;}
    public Cafe(string nombre, double precio, bool tieneLeche) : base(nombre, precio)
    {
        TieneLeche = tieneLeche;
    }

    public override string Preparar()
    {
        if (TieneLeche)
        {
            return "Preparando café con leche";
        }
        else
        {
            return "Preparando café solo";
        }
    }

    public override double MostrarPrecio()
    {
        return Precio;
    }
}