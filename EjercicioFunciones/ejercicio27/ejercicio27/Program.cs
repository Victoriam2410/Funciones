// Crear un procedimiento que solicite el precio de un producto y muestre el precio con un descuento del 10%.
CalcularPrecio();
void CalcularPrecio()
{
    Console.Write("Ingrese el precio del producto: ");
    double precio = double.Parse(Console.ReadLine());

    double descuento = precio * 0.10;
    double total = precio - descuento;

    Console.WriteLine($"El precio con el 10% de descuento es: {total}");
}