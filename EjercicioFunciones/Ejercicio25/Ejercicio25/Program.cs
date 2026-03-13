// Crear un procedimiento que solicite la base y la altura de un rectángulo y muestre su área.
CalcularArea();
void CalcularArea()
{
    Console.Write("Ingrese la base: ");
    double b = double.Parse(Console.ReadLine());

    Console.Write("Ingrese la altura: ");
    double h = double.Parse(Console.ReadLine());

    double area = b * h;

    Console.WriteLine($"el área del rectangulo es: {area}");
}