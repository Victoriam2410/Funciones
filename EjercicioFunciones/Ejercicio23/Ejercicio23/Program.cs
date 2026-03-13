// Crear un procedimiento que solicite dos números al usuario y muestre la suma de ambos.
SumarNumeros();
void SumarNumeros()
{
    Console.Write("Ingrese el primer número: ");
    double n1 = double.Parse(Console.ReadLine());

    Console.Write("Ingrese el segundo número: ");
    double n2 = double.Parse(Console.ReadLine());

    double suma = n1 + n2;
    Console.WriteLine($"la suma de ambos números es: {suma}");
}