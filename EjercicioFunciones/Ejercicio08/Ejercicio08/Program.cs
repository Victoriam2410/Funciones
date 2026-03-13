//Crear una función que reciba tres números y devuelva el promedio de los tres.
Console.WriteLine("ingrese el primer numero");
int numero1= int.Parse(Console.ReadLine());
Console.WriteLine("ingrese el segundo numero");
int numero2 = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese el tercer numero");
int numero3 = int.Parse(Console.ReadLine());
Console.WriteLine($"El promedio es: {promedio(numero1, numero2, numero3)}");
int promedio(int n1, int n2,int n3)
{
    return (n1 + n2 + n3) / 3;
}