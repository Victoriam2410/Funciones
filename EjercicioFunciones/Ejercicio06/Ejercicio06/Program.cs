//Crear una función que reciba un número en grados Celsius y devuelva el valor convertido a Fahrenheit.
//(0 °C × 9/5) + 32 = 32 °F
Console.WriteLine("ingrese grados Celsius :");
int celsius = int. Parse(Console.ReadLine());
Console.WriteLine($"{conversion(celsius)}°F");
int conversion (int c)
{
    return (c * 9 / 5) + 32;
}