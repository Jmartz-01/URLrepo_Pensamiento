// Sistema de Cajero Automatico
int opcion = 0;
double saldo = 1000;
double n1 = 0;

do
{
    Console.WriteLine("Saldo actual: " + saldo);
    Console.WriteLine("1. Consultar saldo");
    Console.WriteLine("2. Depositar dinero");
    Console.WriteLine("3. Retirar dinero");
    Console.WriteLine("4. Salir");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Su saldo es: " + saldo);
            break;

        case 2:
            Console.WriteLine("Cantidad a depositar:");
            n1 = double.Parse(Console.ReadLine());
            saldo = saldo + n1;
            Console.WriteLine("Deposito exitoso");
            break;

        case 3:
            Console.WriteLine("Cantidad a retirar:");
            n1 = double.Parse(Console.ReadLine());

            // Validacion de saldo disponible
            if (n1 > saldo)
            {
                Console.WriteLine("Fondos insuficientes");
            }
            else
            {
                // Mensaje de seguridad
                if (n1 > 500)
                {
                    Console.WriteLine("Alerta de seguridad: Retiro alto");
                }

                saldo = saldo - n1;
                Console.WriteLine("Retiro realizado");
            }
            break;

        case 4:
            Console.WriteLine("Gracias por usar el cajero");
            break;
    }
} while (opcion != 4);