// Crear una función que reciba el nombre de un estudiante y tres calificaciones y devuelva el promedio final.
Console.Write("Ingrese el nombre del estudiante: ");
string nombre = Console.ReadLine();
Console.Write("Ingrese la primera nota: ");
double numero1 = double.Parse(Console.ReadLine());
Console.Write("Ingrese la segunda nota: ");
double numero2 = double.Parse(Console.ReadLine());
Console.Write("Ingrese la tercera nota: ");
double numero3 = double.Parse(Console.ReadLine());
Console.WriteLine($"El promedio de {nombre} es: {Promedio(numero1, numero2, numero3)}");
double Promedio(double a, double b, double c)
{
    return (a + b + c) / 3;
}