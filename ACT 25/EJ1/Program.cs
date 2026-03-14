// Registro de Usuarios
int opcion = 0;
int edad = 0;
int tipoNum = 0;
string nombre = "";
string correo = "";
string tipoUsuario = "";

do
{
    Console.WriteLine("1. Registrar usuario");
    Console.WriteLine("2. Mostrar usuario");
    Console.WriteLine("3. Buscar usuario");
    Console.WriteLine("4. Salir");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Nombre:");
            nombre = Console.ReadLine();
            if (nombre.Length < 3)
            {
                Console.WriteLine("Error: Nombre muy corto");
            }

            Console.WriteLine("Edad:");
            edad = int.Parse(Console.ReadLine());
            if (edad < 18)
            {
                Console.WriteLine("Es menor de edad");
            }

            Console.WriteLine("Correo:");
            correo = Console.ReadLine();
            if (!correo.Contains("@"))
            {
                Console.WriteLine("Advertencia: Correo no valido");
            }

            Console.WriteLine("Tipo: 1.Admin, 2.Cliente, 3.Invitado");
            tipoNum = int.Parse(Console.ReadLine());
            switch (tipoNum)
            {
                case 1: tipoUsuario = "Administrador"; break;
                case 2: tipoUsuario = "Cliente"; break;
                case 3: tipoUsuario = "Invitado"; break;
            }
            break;

        case 2:
            Console.WriteLine("Usuario: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Correo: " + correo);
            Console.WriteLine("Tipo: " + tipoUsuario);
            break;

        case 3:
            Console.WriteLine("Ingrese nombre a buscar:");
            string buscar = Console.ReadLine();
            if (buscar == nombre)
            {
                Console.WriteLine("Usuario encontrado: " + nombre);
            }
            else
            {
                Console.WriteLine("No encontrado");
            }
            break;
    }
} while (opcion != 4);