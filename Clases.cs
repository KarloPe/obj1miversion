using System.Drawing;

namespace libreriaClases {

    class Silla {

        //atributos
        public string color;
        public string material;

        //metodos
        public string crear(){

            return "Hola... creando...";
        }
        public void mover(string pNombre){

            Console.WriteLine("La silla {0} se está moviendo", pNombre);

        }
    }
}