using libreriaClases;

namespace otraLibreria{

    class Principal{

        static void Main(){

        Persona p1 = new Persona(11114556, "Carlos", "01/01/80");
        Persona p2 = new Persona (22235,"Marin","02/02/88");

        Console.WriteLine (p1.Respirar());

        Console.WriteLine (p1.dni);
        Console.WriteLine (p1.nombre);
        Console.WriteLine (p1.fecNac);
        Console.WriteLine (p1.vivo);

        Console.WriteLine ("");

        Console.WriteLine (p2.dni);
        Console.WriteLine (p2.nombre);
        Console.WriteLine (p2.fecNac);
        Console.WriteLine (p2.vivo);

        p2.Morir ();
        p2.Revivir();

        }
    }
}           //cm