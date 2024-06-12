using libreriaClases;

namespace otraLibreria{

    class Principal{

        static void Main(){

            Silla italia = new Silla();
            Silla roberta = new Silla();

            italia.color = "rojo";
            italia.material = "cuero";

            italia.mover("cholo");
            
            Console.WriteLine(italia.crear());
            Console.WriteLine(italia.color);
            Console.WriteLine(italia.material);

            Console.WriteLine(roberta.crear());
            Console.WriteLine(roberta.color);
            Console.WriteLine(roberta.material);

            roberta.mover("roberta");
            
        }
    }
}