using PiedraPapelTijera;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido a PIEDRA PAPEL TIJERAS");
        Console.WriteLine("El vencedor de 3 duelos gana el juego");
        try
        {
            Jugada();
            Console.WriteLine("\nPara jugar nuevamente ingrese 1, para salir ingrese cualquier numero");
            var seguir = Convert.ToInt32(Console.ReadLine());

            while (seguir == 1)
            {
                Jugada();
                Console.WriteLine("\nPara jugar nuevamente ingrese 1, para salir ingrese cualquier numero");
                seguir = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Espero te hayas divertido :)");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error, ingresaste un formato incorrecto");
        }
    }

    public static void Jugada() 
    {
        List<ElementoBase> opcionesPC = new List<ElementoBase>
        {
            new Piedra(),
            new Papel(),
            new Tijera()
        };
        Random rand = new Random();
        int index, opcion, ronda = 0, contPC = 0, contJugador = 0; 
        string duelo;
        ElementoBase elementoPC; 
        ElementoBase elementoJugador;        

        do
        {
            Console.WriteLine("\nRonda {0}", ++ronda);
            index = rand.Next(opcionesPC.Count);
            elementoPC = opcionesPC[index];
            Console.WriteLine("Elija una opción para jugar: 1- Piedra 2- Papel 3-Tijera");
            opcion = Convert.ToInt32(Console.ReadLine());

            while (opcion < 1 || opcion > 3)
            {
                Console.WriteLine("Opción incorrecta, intente nuevamente:  1- Piedra 2- Papel 3-Tijera");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            if (opcion == 1)
            {
                elementoJugador = new Piedra();         
            }
            else if (opcion == 2)
            {
                elementoJugador = new Papel();
            }
            else
            {
                elementoJugador = new Tijera();
            }

            duelo = elementoJugador.ResultadoContra(elementoPC);
            switch (duelo)
            {
                case "gana": Console.WriteLine("Ganaste el duelo!"); contJugador++; break;
                case "pierde": Console.WriteLine("Perdiste el duelo :("); contPC++; break;
                default: Console.WriteLine("¡Empate!"); break;
            }

            Console.WriteLine("Puntos Jugador {0}\nPuntos PC: {1}", contJugador, contPC);

        } while (contPC < 3 && contJugador < 3);

        Console.WriteLine("\n¡Juego Terminado!");
        Console.WriteLine("Cantidad de rondas: {0}", ronda);
        if (contJugador > contPC)
        {
            Console.WriteLine("Felicidades, ganaste contra la PC!! \nPuntos Jugador {0}\nPuntos PC: {1}", contJugador, contPC);
        }
        else
        {
            Console.WriteLine("Perdiste contra la PC :( pero no te desanimes, puedes ganar en otra partida! \nPuntos Jugador {0}\nPuntos PC: {1}", contJugador, contPC);
        }
    }
}