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
public SugeridorReceta(string Nombre,DateTime FechaNacimiento,string TipoDeComida,string Presupuesto,int comesales)
{
    this.Nombre=Nombre;
    this.FechaNacimiento=FechaNacimiento;
    this.TipoDeComida=TipoDeComida;
    this.Presupuesto=Presupuesto;
    this.comesales=comesales;
}
public int CalcularEdad()
{
 int edad = fechaNacimiento - DateTime.Today;
 return edad;
}
