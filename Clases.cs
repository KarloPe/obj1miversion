using System.Drawing;

namespace libreriaClases {

    class Silla {

        //atributos
        public string color=string.Empty;
        public string material=string.Empty;
        //public string material;
        //string.Empty es para el error 8618 Nonnullable reference puede ser null, entonces inicializo y listo

        //metodos
        public string Crear(){

            return "Hola... creando...";
        }
        public void Mover(string pNombre){

            Console.WriteLine("La silla {0} se está moviendo", pNombre);

        }
    }
}           //cm