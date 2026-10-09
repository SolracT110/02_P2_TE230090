Console.WriteLine("02_SISTEMA DE Cilindro Neumatico");
Console.WriteLine();

// Clases: CilindroNeumatico
// Objetos: cilindro
// Propiedades: presionKPa, areaCm2 y fuerzaMinima
// Metodos: CalcularFuerza y EvaluarRequerimiento

CilindroNeumatico cilindro = new CilindroNeumatico();

// INGRESADO DE DATOS DEL CILINDRO
Console.Write("Ingrese la presión (kPa): ");
cilindro.presionKPa = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el área efectiva del pistón (cm²): ");
cilindro.areaCm2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el requerimiento mínimo de fuerza (N): ");
cilindro.fuerzaMinima = Convert.ToDouble(Console.ReadLine());

// Solicitar al objeto los cálculos
double fuerza = cilindro.CalcularFuerza();
string estado = cilindro.EvaluarRequerimiento();

// MOSTRAR RESULTADOS
Console.WriteLine();
Console.WriteLine($"Fuerza ejercida: {fuerza} N");
Console.WriteLine($"Estado de evaluación: {estado}");

// Definición de la clase
class CilindroNeumatico
{
    // Propiedades
    public double presionKPa { get; set; }
    public double areaCm2 { get; set; }
    public double fuerzaMinima { get; set; }

    // Método para calcular la fuerza F = P * A (con conversiones)
    public double CalcularFuerza()
    {
        double presionPa = presionKPa * 1000;
        double areaM2 = areaCm2 / 10000;
        return presionPa * areaM2;
    }

    // Método para evaluar si cumple el requerimiento
    public string EvaluarRequerimiento()
    {
        double fuerzaCalculada = CalcularFuerza();
        if (fuerzaCalculada >= fuerzaMinima)
        {
            return "CUMPLE REQUERIMIENTO";
        }
        else
        {
            return "NO CUMPLE REQUERIMIENTO";
        }
    }
}
