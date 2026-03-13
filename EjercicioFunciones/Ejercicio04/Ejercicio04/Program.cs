// Crear una función que reciba el radio de un círculo y devuelva el área del círculo.
Console.WriteLine("ingrese el radio del circulo: ");
double radio= double.Parse(Console.ReadLine());
Console.WriteLine($"el area es: {area (radio)}");
double area (double r)
{
    return 3.14 * (r* r);
}

