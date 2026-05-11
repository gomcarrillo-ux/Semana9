// temperatura semanal, promedio, temperatura maxima y temperatura minima
int[] temperaturas = new int[7];
int suma = 0;
double promedio = 0;
for (int i = 0; i < temperaturas.Length; i++)
{
    Console.WriteLine($"Ingrese la temperatura del día {i + 1}:");
    temperaturas[i] = int.Parse(Console.ReadLine()!);
}
for (int i = 0; i < temperaturas.Length; i++)
{
    suma += temperaturas[i];
}
promedio = suma / temperaturas.Length;
int temperaturaMaxima = temperaturas[0];
int temperaturaMinima = temperaturas[0];
for (int i = 0; i < temperaturas.Length; i++)
{
    if (temperaturas[i] > temperaturaMaxima)
    {
        temperaturaMaxima = temperaturas[i];
    }
    if (temperaturas[i] < temperaturaMinima)
    {
        temperaturaMinima = temperaturas[i];
    }
}
Console.WriteLine("RESULTADOS");
Console.WriteLine($"El promedio semanal es: {promedio}°C");
Console.WriteLine($"La temperatura más alta es: {temperaturaMaxima}°C");
Console.WriteLine($"La temperatura más baja es: {temperaturaMinima}°C");