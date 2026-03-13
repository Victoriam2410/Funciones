// Crear una función que reciba una cantidad de minutos y devuelva el equivalente en horas.
Console.Write("Ingrese la cantidad de minutos: ");
double minutos = double.Parse(Console.ReadLine());
Console.WriteLine($"El equivalente en horas es: {ConvertirAHoras(minutos)}");
double ConvertirAHoras(double m)
{
    return m / 60;
}