

using System.Drawing;

namespace libreriaClases {

    class silla {

        //atributos
        public string color;
        public string material;


        //metodos

        public string crear(){

            return "hola";
        }

        public void mover(string pNombre){

            Console.WriteLine("La silla se está moviendo {0}", pNombre);

        }


    }
}