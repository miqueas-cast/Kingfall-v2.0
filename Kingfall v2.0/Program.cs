using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kingfall_v2._0
{

    internal class Program
    {
        // constraseñas y usuarios predefinidos para el login
        static string[] usuarios = { "diana", "ivan", "miqueas" };
        static string[] contrasenas = { "Kingfa!!1", "Jugad0r#2", "Jueg0Kingfa!!"}; 

        static void Main(string[] args)
        {  
            // para mostrar flecha en las reglas
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            /*
            Console.WriteLine("   ▄█   ▄█▄  ▄█  ███▄▄▄▄      ▄██████▄     ▄████████    ▄████████  ▄█        ▄█       \r\n  ███ ▄███▀ ███  ███▀▀▀██▄   ███    ███   ███    ███   ███    ███ ███       ███       \r\n  ███▐██▀   ███▌ ███   ███   ███    █▀    ███    █▀    ███    ███ ███       ███       \r\n ▄█████▀    ███▌ ███   ███  ▄███         ▄███▄▄▄       ███    ███ ███       ███       \r\n▀▀█████▄    ███▌ ███   ███ ▀▀███ ████▄  ▀▀███▀▀▀     ▀███████████ ███       ███       \r\n  ███▐██▄   ███  ███   ███   ███    ███   ███          ███    ███ ███       ███       \r\n  ███ ▀███▄ ███  ███   ███   ███    ███   ███          ███    ███ ███▌    ▄ ███▌    ▄ \r\n  ███   ▀█▀ █▀    ▀█   █▀    ████████▀    ███          ███    █▀  █████▄▄██ █████▄▄██ \r\n  ▀                                                               ▀         ▀         ");
            Thread.Sleep(2500);
            Console.Clear();

            //Pantalla de inicio
            Console.WriteLine("===== BIENVENIDO AL JUEGO ====="); 
            Thread.Sleep(1500);
            Console.Clear();

            //Login
            string usuario, contrasena;
            
            do
            {
                Console.Write("Ingrese su usuario: ");
                usuario = Console.ReadLine();

                if (!UsuarioExiste(usuario))
                    Console.WriteLine("El usuario no existe, intenta de nuevo.\n");

            }
            while (!UsuarioExiste(usuario));

            do
            {
                Console.Write("Ingrese su contraseña: ");
                contrasena = LeerContra();

                if (!ValidarFormato(contrasena))
                {
                    Console.WriteLine("No cumple con las reglas de seguridad.\n");
                    continue;
                }
                if (!ContrasenaCorrecta(usuario, contrasena))
                    Console.WriteLine("Contraseña incorrecta, intenta de nuevo.\n");

            } while (!ContrasenaCorrecta(usuario, contrasena));

            Console.Clear();
            Console.WriteLine($"Acceso concedido...\n\nBienvenido {usuario}");

            Thread.Sleep(2300);

            Console.Clear();
            
            */
            // variables globales

            string nombrePuntajeMasAlto = "";
            int puntajeJugador1 = 0;
            int puntajeJugador2 = 0;
            int piezasRestantesJugador1 = 7;
            int piezasRestantesJugador2 = 7;
            int recordInicial = 0;
            bool hayPuntajeRegistrado = false;
            bool salir = false;
            do
            {
                Console.Clear();
                Console.Beep();

                int opcion = ValidacionEntradas($"Menú:\n1. Iniciar partida\r\n2. Ver reglas del juego\r\n3. Ver puntaje más alto\r\n4. Salir\n> ", 1, 4);
                switch (opcion)
                {
                    case 1:

                        //Reinicio de puntajes
                        puntajeJugador1 = 0;
                        puntajeJugador2 = 0;
                        nombrePuntajeMasAlto = "";
                        piezasRestantesJugador1 = 7;
                        piezasRestantesJugador2 = 7;

                        //Creación del tablero 
                        Tablero tablero = new Tablero();

                        // jugador1 piezas
                        Jugador jugador1 = new Jugador();

                        jugador1.Nombre = "Diana";
                        jugador1.Numero = 1;

                        Pieza rey = new Pieza();
                        rey.Tipo = "Rey";
                        rey.Simbolo = 'r';
                        rey.Dueño = jugador1;

                        Pieza torre = new Pieza();
                        torre.Tipo = "Torre";
                        torre.Simbolo = 't';
                        torre.Dueño = jugador1;

                        Pieza torre1 = new Pieza();
                        torre1.Tipo = "Torre";
                        torre1.Simbolo = 't';
                        torre1.Dueño = jugador1;

                        Pieza soldado = new Pieza();
                        soldado.Tipo = "Soldado";
                        soldado.Simbolo = 's';
                        soldado.Dueño = jugador1;

                        Pieza soldado1 = new Pieza();
                        soldado1.Tipo = "Soldado";
                        soldado1.Simbolo = 's';
                        soldado1.Dueño = jugador1;

                        Pieza soldado2 = new Pieza();
                        soldado2.Tipo = "Soldado";
                        soldado2.Simbolo = 's';
                        soldado2.Dueño = jugador1;

                        Pieza soldado3 = new Pieza();
                        soldado3.Tipo = "Soldado";
                        soldado3.Simbolo = 's';
                        soldado3.Dueño = jugador1;


                        // jugador 2
                        Jugador jugador2 = new Jugador();
                        jugador2.Nombre = "Ivan";
                        jugador2.Numero = 2;

                        Pieza rey2 = new Pieza();
                        rey2.Tipo = "Rey";
                        rey2.Simbolo = 'R';
                        rey2.Dueño = jugador2;

                        Pieza torre2 = new Pieza();
                        torre2.Tipo = "Torre";
                        torre2.Simbolo = 'T';
                        torre2.Dueño = jugador2;

                        Pieza torre3 = new Pieza();
                        torre3.Tipo = "Torre";
                        torre3.Simbolo = 'T';
                        torre3.Dueño = jugador2;

                        Pieza soldado4 = new Pieza();
                        soldado4.Tipo = "Soldado";
                        soldado4.Simbolo = 'S';
                        soldado4.Dueño = jugador2;

                        Pieza soldado5 = new Pieza();
                        soldado5.Tipo = "Soldado";
                        soldado5.Simbolo = 'S';
                        soldado5.Dueño = jugador2;

                        Pieza soldado6 = new Pieza();
                        soldado6.Tipo = "Soldado";
                        soldado6.Simbolo = 'S';
                        soldado6.Dueño = jugador2;

                        Pieza soldado7 = new Pieza();
                        soldado7.Tipo = "Soldado";
                        soldado7.Simbolo = 'S';
                        soldado7.Dueño = jugador2;


                        // Posiciones iniciales jugador 1
                        tablero.Casillas[0, 0] = torre;
                        tablero.Casillas[0, 1] = soldado;
                        tablero.Casillas[0, 2] = soldado1;
                        tablero.Casillas[0, 3] = rey;
                        tablero.Casillas[0, 4] = soldado2;
                        tablero.Casillas[0, 5] = soldado3;
                        tablero.Casillas[0, 6] = torre1;

                        // Posiciones iniciales jugador 2
                        tablero.Casillas[7, 0] = torre2;
                        tablero.Casillas[7, 1] = soldado4;
                        tablero.Casillas[7, 2] = soldado5;
                        tablero.Casillas[7, 3] = rey2;
                        tablero.Casillas[7, 4] = soldado6;
                        tablero.Casillas[7, 5] = soldado7;
                        tablero.Casillas[7, 6] = torre3;

                        tablero.MostrarTablero(tablero);

                        Jugador jugadorActual = jugador1;

                        while (true)
                        {
                            Console.Clear();
                            tablero.MostrarTablero(tablero);
                            Console.WriteLine("Turno de: " + jugadorActual.Nombre);
                            Console.WriteLine();
                            Pieza piezaMover;

                            // Ingresar la posición de la pieza a mover
                            int filaOrigen;
                            int columnaOrigen;
                            do
                            {
                                filaOrigen = ValidacionTablero("Fila origen: ", 0, 7, tablero);
                                columnaOrigen = ValidacionTablero("Columna origen: ", 0, 7, tablero);

                                piezaMover = tablero.Casillas[filaOrigen, columnaOrigen];
                                if (piezaMover == null)
                                {
                                    Console.Clear();
                                    tablero.MostrarTablero(tablero);
                                    Console.WriteLine("Turno de: " + jugadorActual.Nombre);
                                    Console.WriteLine("No hay pieza en esa posición");

                                    continue;
                                }
                                if (piezaMover.Dueño != jugadorActual)
                                {
                                    Console.WriteLine("No puedes mover la pieza del oponente");

                                    continue;
                                }
                                break;
                            } while (true);

                            // Ingresar la posición de destino
                            int filaDestino;
                            int columnaDestino;
                            do
                            {
                                filaDestino = ValidacionTablero("Fila destino:", 0, 7, tablero);
                                columnaDestino = ValidacionTablero("Columna destino:", 0, 7, tablero);

                                Pieza piezaDestino = tablero.Casillas[filaDestino, columnaDestino];
                                if (piezaDestino != null && piezaDestino.Dueño == jugadorActual)
                                {
                                    Console.WriteLine("No puedes moverte sobre tu propia pieza");
                                    Console.ReadKey();
                                    continue;
                                }
                                break;

                            } while (true);

                            // función para validar el movimiento por tipo de pieza
                            bool movimientoValido = piezaMover.MovimientoValidoPorTipo(filaOrigen, columnaOrigen, filaDestino, columnaDestino, tablero);

                            if (!movimientoValido)
                            {
                                Console.WriteLine("Movimiento inválido para esa pieza");
                                Console.ReadKey();
                                continue;
                            }


                            // movimiento de piezas
                            Pieza piezaCapturada = tablero.Casillas[filaDestino, columnaDestino];
                            tablero.Casillas[filaDestino, columnaDestino] = piezaMover;
                            tablero.Casillas[filaOrigen, columnaOrigen] = null;


                            //Sistema de puntajes
                            if (piezaCapturada != null)
                            {
                                Console.Beep();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"\n⚔️ {jugadorActual.Nombre} capturó un {piezaCapturada.Tipo} de {piezaCapturada.Dueño.Nombre}!");
                                Console.ResetColor();
                                Console.ReadKey();

                                // if para determinar cuantas piezas restantes le quedan al jugador
                                if (piezaCapturada.Dueño == jugador1)
                                {
                                    piezasRestantesJugador1--;
                                }
                                else
                                {
                                    piezasRestantesJugador2--;
                                }
                                if (piezaCapturada.Tipo == "Rey")
                                {
                                    if (jugadorActual == jugador1)
                                    {

                                        puntajeJugador1 += 60;
                                    }
                                    else
                                    {
                                        puntajeJugador2 += 60;
                                    }

                                    Console.Clear();
                                    tablero.MostrarTablero(tablero);
                                    Console.WriteLine($"El jugador {jugadorActual.Nombre} ha ganado porque capturó al Rey");
                                    break;
                                }
                                else
                                {
                                    if (jugadorActual == jugador1)
                                    {
                                        puntajeJugador1 += 10;
                                    }
                                    else
                                    {
                                        puntajeJugador2 += 10;
                                    }
                                }

                                if (piezasRestantesJugador1 == 0)
                                {
                                    Console.Clear();
                                    tablero.MostrarTablero(tablero);
                                    Console.WriteLine($"El jugador {jugador2.Nombre} ha ganado la partida");
                                    break;
                                }

                                if (piezasRestantesJugador2 == 0)
                                {
                                    Console.Clear();
                                    tablero.MostrarTablero(tablero);
                                    Console.WriteLine($"El jugador {jugador1.Nombre} ha ganado la partida");
                                    break;
                                }
                            }

                            // Cambiar Turnos
                            if (jugadorActual == jugador1)
                            {
                                jugadorActual = jugador2;
                            }
                            else
                            {
                                jugadorActual = jugador1;
                            }
                        }
                        // determinar puntajeGanador
                        int puntajeGanador;

                        if (jugadorActual == jugador1)
                        {
                            puntajeGanador = puntajeJugador1;
                        }
                        else
                        {
                            puntajeGanador = puntajeJugador2;
                        }

                        if (!hayPuntajeRegistrado || puntajeGanador > recordInicial)
                        {
                            recordInicial = puntajeGanador;
                            nombrePuntajeMasAlto = jugadorActual.Nombre;
                            hayPuntajeRegistrado = true;
                        }

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
                        Console.WriteLine("║                     REGLAS DEL JUEGO                         ║");
                        Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
                        Console.WriteLine();
                        Console.WriteLine("  OBJETIVO");
                        Console.WriteLine("  ─────────────────────────────────────────────────────────────");
                        Console.WriteLine("  Capturar el Rey del oponente o eliminar todas sus piezas.");
                        Console.WriteLine();
                        Console.WriteLine("  PIEZAS DE CADA JUGADOR");
                        Console.WriteLine("  ─────────────────────────────────────────────────────────────");
                        Console.WriteLine("  · 1 Rey      (R)");
                        Console.WriteLine("  · 2 Torres   (T)");
                        Console.WriteLine("  · 4 Soldados (S)");
                        Console.WriteLine();
                        Console.WriteLine("  MOVIMIENTOS");
                        Console.WriteLine("  ─────────────────────────────────────────────────────────────");
                        Console.WriteLine("  REY     → Se mueve 1 casilla en cualquier dirección");
                        Console.WriteLine("             (horizontal, vertical o diagonal).");
                        Console.WriteLine();
                        Console.WriteLine("  TORRE   → Se mueve en línea recta (horizontal o vertical)");
                        Console.WriteLine("             cualquier número de casillas.");
                        Console.WriteLine("             No puede saltar otras piezas.");
                        Console.WriteLine();
                        Console.WriteLine("  SOLDADO → Avanza 1 casilla hacia adelante.");
                        Console.WriteLine("             Ataca en diagonal (1 casilla).");
                        Console.WriteLine("             No puede retroceder.");
                        Console.WriteLine();
                        Console.WriteLine("  CÓMO ATACAR");
                        Console.WriteLine("  ─────────────────────────────────────────────────────────────");
                        Console.WriteLine("  Si una pieza se mueve a una casilla ocupada por el rival,");
                        Console.WriteLine("  la pieza rival es eliminada del tablero.");
                        Console.WriteLine();
                        Console.WriteLine("  TURNO");
                        Console.WriteLine("  ─────────────────────────────────────────────────────────────");
                        Console.WriteLine("  Los jugadores alternan turnos. En cada turno debes indicar");
                        Console.WriteLine("  la fila y columna de origen, y la fila y columna de destino.");
                        Console.WriteLine();
                        Console.WriteLine("  PROHIBIDO");
                        Console.WriteLine("  ─────────────────────────────────────────────────────────────");
                        Console.WriteLine("  · Salir de los límites del tablero.");
                        Console.WriteLine("  · Mover piezas del oponente.");
                        Console.WriteLine("  · Mover a una casilla ocupada por una pieza propia.");
                        Console.WriteLine("  · Realizar movimientos que no correspondan a la pieza.");
                        Console.WriteLine("  · Que la Torre salte otras piezas.");
                        Console.WriteLine();
                        Console.WriteLine("  PUNTAJE");
                        Console.WriteLine("  ─────────────────────────────────────────────────────────────");
                        Console.WriteLine("  · Soldado capturado  →  10 puntos");
                        Console.WriteLine("  · Torre capturada    →  10 puntos");
                        Console.WriteLine("  · Rey capturado      →  60 puntos (10 + 50 adicionales)");
                        Console.WriteLine();
                        Console.WriteLine("══════════════════════════════════════════════════════════════");
                        Console.WriteLine();
                        Console.Write("  Presiona Enter para volver al menú...");

                        Console.ReadKey();
                        
                        break;
                    case 3:
                        Console.Clear();
                        if (!hayPuntajeRegistrado)
                        {
                            Console.WriteLine("Aún no hay puntajes registrados");
                        }
                        else
                        {
                            Console.WriteLine("Puntaje más alto");
                            Console.WriteLine($"Jugador: {nombrePuntajeMasAlto}");
                            Console.WriteLine($"Puntos: {recordInicial}");
                        }

                        Console.ReadKey();

                        break;
                    case 4:
                        Console.Clear();
                        salir = true;
                        Console.WriteLine("Saliendo del juego...");
                        Thread.Sleep(2000);
                        break;
                }

            } while (!salir);
        }
        static int ValidacionTablero(string mensaje, int min, int max, Tablero tablero)
        {
            int valor;
            bool esValido;
            do
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();
                esValido = int.TryParse(entrada, out valor);
                if (!esValido)
                {
                    Console.Clear();
                    tablero.MostrarTablero(tablero);
                    Console.WriteLine($"Por favor ingrese una posición valida");
                }
                if (esValido && (valor < min || valor > max))
                {
                    Console.Clear();
                    tablero.MostrarTablero(tablero);
                    Console.WriteLine($"Posición fuera del rango");
                    esValido = false;
                }
            } while (!esValido);
            return valor;
        }
        //convertir a enteros
        static int ValidacionEntradas(string mensaje, int min, int max)
        {
            int valor;
            bool esValido;
            do
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();
                esValido = int.TryParse(entrada, out valor) && valor >= min && valor <= max;
                if (!esValido)
                {
                    Console.Clear();
                    Console.WriteLine($"Por favor, ingresa un número.");
                }
            } while (!esValido);
            return valor;
        }
        static bool UsuarioExiste(string usuario)
        {
            for (int i = 0; i < usuarios.Length; i++)
            {
                if (usuarios[i] == usuario)
                    return true;
            }
            return false;
        }

        static bool ContrasenaCorrecta(string usuario, string contrasena)
        {
            for (int i = 0; i < usuarios.Length; i++)
            {
                if (usuarios[i] == usuario && contrasenas[i] == contrasena)
                    return true;
            }
            return false;
        }
        static bool ValidarFormato(string contra)
        {
            if (contra.Length < 8) return false;
            bool mayuscula = false, minuscula = false, numero = false, especial = false;
            foreach (char d in contra) // El foreach sirve para que revise letra por letra lo que se va a escribir de contraseña (en este caso).
            { //El char d significa que se va a guardar cada carácter de la contraseña en la variable d
                if (char.IsUpper(d)) mayuscula = true;
                else if (char.IsLower(d)) minuscula = true;
                else if (char.IsDigit(d)) numero = true;
                else especial = true;
            }
            return mayuscula && minuscula && numero && especial;
        }

        static string LeerContra()
        {
            string contra = "";
            ConsoleKeyInfo tecla; //Guarda el carácter especial

            do
            {
                tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.Backspace && contra.Length > 0)
                {
                    contra = contra.Substring(0, contra.Length - 1); //Si por accidente se confunden en escribir la contraseña entonces borra el carácter y no lo cuenta como parte de la contraseña
                    Console.Write("\b \b"); //Borra el asterisco
                }

                else if (tecla.Key != ConsoleKey.Enter && contra.Length < 13)
                {
                    contra += tecla.KeyChar;
                    Console.Write("•");
                }
            } while (tecla.Key != ConsoleKey.Enter);
            Console.WriteLine();
            return contra;
        }  

    }
    class Jugador
    {
        public string Nombre;
        public int Numero;
        public int puntos;

    }
    class Pieza
    {
        public string Tipo;
        public char Simbolo;
        public Jugador Dueño;

        public bool MovimientoValidoPorTipo(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino, Tablero tablero)
        {
            if (Tipo == "Rey")
            {
                return MovimientoValidoRey(filaOrigen, columnaOrigen, filaDestino, columnaDestino, tablero);
            }
            else if (Tipo == "Torre")
            {
                return MovimientoValidoTorre(filaOrigen, columnaOrigen, filaDestino, columnaDestino, tablero);
            }
            else if (Tipo == "Soldado")
            {
                return MovimientoValidoSoldado(filaOrigen, columnaOrigen, filaDestino, columnaDestino, tablero);
            }

            return false;
        }
        private bool MovimientoValidoRey(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino, Tablero tablero)
        {
            int diferenciaFila = Math.Abs(filaDestino - filaOrigen);
            int diferenciaColumna = Math.Abs(columnaDestino - columnaOrigen);

            return diferenciaFila <= 1 && diferenciaColumna <= 1;
        }

        private bool MovimientoValidoTorre(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino, Tablero tablero)
        {
            bool mismaFila = filaOrigen == filaDestino;
            bool mismaColumna = columnaOrigen == columnaDestino;

            if (!mismaFila && !mismaColumna)
            {
                return false;
            }

            return tablero.CaminoLibre(filaOrigen, columnaOrigen, filaDestino, columnaDestino);
        }

        private bool MovimientoValidoSoldado(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino, Tablero tablero)
        {
            int direccion;

            if (Dueño.Numero == 1)
            {
                direccion = 1;
            }
            else
            {
                direccion = -1;
            }

            int diferenciaFila = filaDestino - filaOrigen;
            int diferenciaColumna = columnaDestino - columnaOrigen;

            Pieza piezaDestino = tablero.Casillas[filaDestino, columnaDestino];

            bool avanzaRecto = diferenciaFila == direccion &&
                               diferenciaColumna == 0 &&
                               piezaDestino == null;

            bool atacaDiagonal = diferenciaFila == direccion &&
                                 Math.Abs(diferenciaColumna) == 1 &&
                                 piezaDestino != null &&
                                 piezaDestino.Dueño != Dueño;

            return avanzaRecto || atacaDiagonal;
        }
    }
    class Tablero
    {
        public Pieza[,] Casillas = new Pieza[8, 8];

        public void MostrarTablero(Tablero tablero)
        {
            Console.Write("    ");
            for (int columna = 0; columna < 8; columna++)
            {
                Console.Write($"{columna}   ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int fila = 0; fila < 8; fila++)
            {
                Console.Write(fila + "   ");

                for (int columna = 0; columna < 8; columna++)
                {
                    Pieza piezaActual = tablero.Casillas[fila, columna];

                    if (piezaActual == null)
                    {
                        Console.Write(".   ");
                    }
                    else
                    {
                        Console.Write(piezaActual.Simbolo + "   ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        public bool CaminoLibre(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino)
        {
            int avanceFila = 0;
            int avanceColumna = 0;

            if (filaDestino > filaOrigen)
            {
                avanceFila = 1;
            }
            else if (filaDestino < filaOrigen)
            {
                avanceFila = -1;
            }

            if (columnaDestino > columnaOrigen)
            {
                avanceColumna = 1;
            }
            else if (columnaDestino < columnaOrigen)
            {
                avanceColumna = -1;
            }

            int filaActual = filaOrigen + avanceFila;
            int columnaActual = columnaOrigen + avanceColumna;

            while (filaActual != filaDestino || columnaActual != columnaDestino)
            {
                if (Casillas[filaActual, columnaActual] != null)
                {
                    return false;
                }

                filaActual += avanceFila;
                columnaActual += avanceColumna;
            }

            return true;
        }
    }
}
