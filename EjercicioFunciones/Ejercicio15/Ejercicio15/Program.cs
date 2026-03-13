//Crear una función que reciba la base y la altura de un triángulo y devuelva su área.
Console.Write("Ingrese la base: ");
double basee = double.Parse(Console.ReadLine());
Console.Write("Ingrese la altura: ");
double altura= double.Parse(Console.ReadLine());
Console.WriteLine($"El área del triángulo es: {Area(basee, altura)}");
double Area (double b,double a)
{
    return (b * a) / 2;
}