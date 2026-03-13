//Crear una función que reciba un número y devuelva el cubo del número.
Console.WriteLine("ingrese el numero: ");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine($"el cubo del numero: {Cubo(numero)}");
int Cubo (int n)
{
    return n * n * n;
}