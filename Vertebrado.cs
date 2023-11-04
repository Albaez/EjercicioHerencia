using System;


namespace EjercicioHerencia
{
    class Vertebrado : Animal
    {
        public string tipo;
        public bool tienePatas;
        public bool esDomestico;
        public bool esHerbivoro;
        public bool esCarnivoro;

        public void imprimir()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Tamaño: " + tamano);
            Console.WriteLine("Familia: " + familia);
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Tiene patas: " + tienePatas);
            Console.WriteLine("Es doméstico: " + esDomestico);
            Console.WriteLine("Es herbívoro: " + esHerbivoro);
            Console.WriteLine("Es carnívoro: " + esCarnivoro);
        }
    }

}
