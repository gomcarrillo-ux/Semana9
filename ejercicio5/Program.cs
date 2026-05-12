// notas de 8 estudiantes, aprobados, reprobados y promedio
double[] notas = new double[8];
double total = 0;
int contadorReprobados = 0;
for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"Ingrese la nota del estudiante {i + 1}:");
    notas[i] = double.Parse(Console.ReadLine()!);
    total += notas[i];
}
Console.WriteLine("NOTAS APROBADAS (60 o más)");
for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] >= 60)
    {
        Console.WriteLine($"Estudiante {i + 1}: {notas[i]} has aprobado sos tuani");
    }
    else
    {
       contadorReprobados++;
    }
}
double promedioGeneral = total / notas.Length;
Console.WriteLine("Datos del grupo");
Console.WriteLine($"Promedio general del grupo: {promedioGeneral:F2}");
Console.WriteLine($"Cantidad de estudiantes reprobados: {contadorReprobados}");
