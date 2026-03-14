// Sistema de Evaluacion de Estudiantes

int opcion = 0;
string nombre = "";
string curso = "";
string estado = "";
double n1 = 0, n2 = 0, n3 = 0, promedio = 0;

do
{
    Console.WriteLine("1. Registrar estudiante");
    Console.WriteLine("2. Calcular promedio");
    Console.WriteLine("3. Mostrar estado");
    Console.WriteLine("4. Salir");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Nombre:");
            nombre = Console.ReadLine();

            // Revision manual de numeros en el nombre
            for (int i = 0; i < nombre.Length; i++)
            {
                string letra = nombre.Substring(i, 1);
                if (letra == "0" || letra == "1" || letra == "2" || letra == "3" || letra == "4")
                {
                    Console.WriteLine("Advertencia: El nombre tiene numeros");
                    break;
                }
                if (letra == "5" || letra == "6" || letra == "7" || letra == "8" || letra == "9")
                {
                    Console.WriteLine("Advertencia: El nombre tiene numeros");
                    break;
                }
            }

            Console.WriteLine("Curso:");
            curso = Console.ReadLine();

            Console.WriteLine("Nota 1:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota 2:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota 3:");
            n3 = double.Parse(Console.ReadLine());

            if (n1 > 100 || n2 > 100 || n3 > 100)
            {
                Console.WriteLine("Error: Una nota es mayor a 100");
            }
            break;

        case 2:
            promedio = (n1 + n2 + n3) / 3;
            Console.WriteLine("Promedio calculado: " + promedio);

            if (promedio >= 90) { estado = "Excelente"; }
            else if (promedio >= 70) { estado = "Aprobado"; }
            else if (promedio >= 60) { estado = "Recuperacion"; }
            else { estado = "Reprobado"; }
            break;

        case 3:
            Console.WriteLine("Estudiante: " + nombre);
            Console.WriteLine("Curso: " + curso);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Estado: " + estado);
            break;
    }
} while (opcion != 4);