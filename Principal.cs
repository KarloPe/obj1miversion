using libreriaClases;

namespace otraLibreria{

    class Principal{

        static void Main(){

            Silla italia = new Silla();
            Silla roberta = new Silla();

            italia.color = "rojo";
            italia.material = "cuero";

            italia.Mover("cholo");
            
            Console.WriteLine(italia.Crear());
            Console.WriteLine(italia.color);
            Console.WriteLine(italia.material);

            Console.WriteLine(roberta.Crear());
            Console.WriteLine(roberta.color);
            Console.WriteLine(roberta.material);

            roberta.Mover("roberta");
            
        }
    }
}           //cm