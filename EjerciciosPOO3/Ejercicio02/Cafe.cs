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
        return "Preparando café";
    }

    public override double MostrarPrecio()
    {
        return Precio;
    }
}