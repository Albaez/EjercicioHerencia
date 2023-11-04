using System;


namespace EjercicioHerencia
{
    class Invertebrado : Animal
    {
        public string tipo;
        public bool tienePatas;
        public int numeroPatas;
        public bool tieneConcha;

        public void imprimir()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Tamaño: " + tamano);
            Console.WriteLine("Familia: " + familia);
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Tiene patas: " + tienePatas);
            Console.WriteLine("Número de patas: " + numeroPatas);
            Console.WriteLine("Tiene concha: " + tieneConcha);
        }
    }

}
