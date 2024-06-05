using libreriaClases;

namespace otraLibreria{

    class principal{

        static void Main(){

            string nombre;

            silla pepe = new silla();
            silla roberta = new silla();

            pepe.color = "rojo";
            pepe.material = "plastico";

            pepe.mover();

            
            Console.WriteLine(pepe.crear());
            Console.WriteLine(pepe.color);
            Console.WriteLine(pepe.material);

            Console.WriteLine(roberta.crear());
            Console.WriteLine(roberta.color);
            Console.WriteLine(roberta.material);
            




        }
    }
}