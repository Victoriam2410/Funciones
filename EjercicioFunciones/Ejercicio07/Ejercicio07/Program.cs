// Crear una función que reciba el precio de un producto y el porcentaje de descuento y devuelva el precio final.
Console.WriteLine("ingrese precio: ");
double precio = double. Parse(Console.ReadLine());
Console.WriteLine("ingrese el porcentaje de descuento:");
double porsentaje = double.Parse(Console.ReadLine());
Console.WriteLine($"total {total(precio,porsentaje)}");
double total (double p, double t)
    {
    return (p * t) / 100;
    }