using System;

namespace Flujo_de_datos___C2_Ej22
{
    class Program
    {
        static void Main(string[] args)
        {
            String password = "notenter00";
            String passwordintroducida;
            int intentos = 0;
            Boolean acierto = false;

            do
            {
                Console.WriteLine("Introduzca la contraseña:");
                passwordintroducida = Console.ReadLine();
                intentos++;

                if (password == passwordintroducida)
                {
                    acierto = true;
                }
            }
            while ((intentos < 3) & (acierto == false));

            if(acierto)
            {
                Console.WriteLine("Enhorabuena");
            }
            else
            {
                Console.WriteLine("Se excedió el número de intentos");
            }
            
        }
    }
}
