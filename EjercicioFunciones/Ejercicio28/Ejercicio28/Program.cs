//Crear un procedimiento que solicite tres calificaciones y muestre el promedio del estudiante.
CalcularPromedio();
void CalcularPromedio()
{
    Console.WriteLine("Ingrese la primera calificación: ");
    double numero1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la segunda calificación: ");
    double numero2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la tercera calificación: ");
    double numero3 = double.Parse(Console.ReadLine());

    double promedio = (numero1 + numero2 + numero3) / 3;

    Console.WriteLine($"El promedio final es: {promedio}");
}