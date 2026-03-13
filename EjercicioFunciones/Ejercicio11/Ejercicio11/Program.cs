// Crear una función que reciba el peso en kilogramos y devuelva el peso en libras.
Console.WriteLine("ingrese el peso (Kg): ");
double Kilogramos = double.Parse(Console.ReadLine());
Console.WriteLine($"el peso en libras es: {Peso(Kilogramos)} lb");
double Peso(double kg )
{
    return kg*2.205;
}
