// Crear una función que reciba la cantidad de días trabajados y el pago diario y devuelva el salario total del empleado.
Console.Write("ingrese la cantidad de días trabajados: ");
int dias = int.Parse(Console.ReadLine());

Console.Write("ingrese el pago diario: ");
double pago = double.Parse(Console.ReadLine());

Console.WriteLine($"el salario total del empleado es: {SalarioTotal(dias, pago)}");

double SalarioTotal(int d, double p)
{
    return d * p;
}