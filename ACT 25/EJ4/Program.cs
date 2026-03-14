// Sistema de Analisis de Texto
int opcion = 0;
string frase = "";
int contador = 0;

Console.WriteLine("Ingrese una frase:");
frase = Console.ReadLine();

do
{
    Console.WriteLine("1. Contar caracteres");
    Console.WriteLine("2. Contar vocales");
    Console.WriteLine("3. Mayusculas");
    Console.WriteLine("4. Minusculas");
    Console.WriteLine("5. Salir");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            // El Length nos da el total de letras
            Console.WriteLine("Total de caracteres: " + frase.Length);
            break;

        case 2:
            contador = 0;
            // Ciclo para revisar letra por letra
            for (int i = 0; i < frase.Length; i++)
            {
                string letra = frase.Substring(i, 1).ToLower();
                if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
                {
                    contador = contador + 1;
                }
            }
            Console.WriteLine("Total de vocales: " + contador);
            break;

        case 3:
            Console.WriteLine("Frase: " + frase.ToUpper());
            break;

        case 4:
            Console.WriteLine("Frase: " + frase.ToLower());
            break;
    }
} while (opcion != 5);