namespace Tp02_Moguelevsky_Sisro.Models;

public class SugeridorReceta
{
    public string nombre { get; set; }
    public DateTime fechaNacimiento { get; set; }
    public string tipoComida { get; set; }
    public string presupuesto { get; set; }
    public int cantidadComensales { get; set; }
}
public SugeridorReceta()
{

}
public SugeridorReceta(string Nombre,DateTime fechaNacimiento, string tipoComida, string presupuesto, int cantidadComensales)
{
    this.nombre = nombre;
    this.fechaNacimiento = fechaNacimiento;
    this.tipoComida = tipoComida;
    this.presupuesto = presupuesto;
    this.cantidadComensales = cantidadComensales;
}
public int CalcularEdad()
{
 int edad = fechaNacimiento - DateTime.Today;
 return edad;
}
public string DeterminarPlato()
{
    string platoSugerido;
    if(tipoComida = "Caliente" && presupuesto < 3000)
    {
        platoSugerido = "Fideos con manteca";
    }
    else if(tipoComida = "Caliente" && presupuesto < 7000)
    {
        platoSugerido = "Arroz con verduras salteadas";
    }
    else if(tipoComida = "Caliente" && presupuesto > 7000)
    {
        platoSugerido = "Pollo al horno con guarnición";
    }
    else if(tipoComida = "Fría" && presupuesto < 3000)
    {
        platoSugerido = "Ensalada simple";
    }
    else if(tipoComida = "Fría" && presupuesto < 7000)
    {
        platoSugerido = "Ensalada completa con proteína";
    }
    else if(tipoComida = "Fría" && presupuesto > 7000)
    {
        platoSugerido = "Tabla de fiambres y quesos";
    }
    return platoSugerido;
}
    public void calcularTiempo()
    {
        int tiempo;
        if( cantidadComensales < 2 && TipoDeComida == "Caliente" || cantidadComensales > 1 && cantidadComensales <4 && TipoDeComida == "Caliente")
        {
            tiempo = 20;
        }
        else if( cantidadComensales < 8 && TipoDeComida == "Caliente")
        {
            tiempo = 40;
        }
        else if( cantidadComensales >= 8 && TipoDeComida == "Caliente")
        {
            tiempo = 80;
        }
        else if( cantidadComensales > 0 && cantidadComensales < 4 && TipoDeComida == "Fría")
        {
            tiempo = 10;
        }
        else if( cantidadComensales < 8 && TipoDeComida == "Fría")
        {
            tiempo = 20;
        }
        else if( cantidadComensales >= 8 && TipoDeComida == "Fría")
        {
            tiempo = 40;
        }
        return tiempo;
    }
