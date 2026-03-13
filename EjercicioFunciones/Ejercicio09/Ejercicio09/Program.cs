//Crear una función que reciba el salario por hora y las horas trabajadas y devuelva el salario total.
Console.WriteLine("ingrese el salario por hora: ");
int salario = int .Parse(Console.ReadLine());
Console.WriteLine("ingrese las horas trabajadas ");
int horas = int.Parse(Console.ReadLine());
Console.WriteLine($"el salario total es: {SalarioTotal(salario, horas)}");
int SalarioTotal(int s, int h)
{
    return s * h;
}