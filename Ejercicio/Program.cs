using Ejercicio;
Contar_Letras letras = new Contar_Letras();
int LETRAS;

Console.WriteLine("Ingresa tu texto");

LETRAS = letras.Letras(Console.ReadLine());
Console.WriteLine("Tu texto tiene " + LETRAS + " Letras");