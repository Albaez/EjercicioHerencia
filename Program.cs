using System;


namespace EjercicioHerencia
{
    internal class Program
    {
     
            static void Main(string[] args)
            {
                Vertebrado animal1 = new Vertebrado();
                animal1.nombre = "Koala";
                animal1.color = "Gris";
                animal1.tamano = 1.00f;
                animal1.familia = "Phascolarctidae";
                animal1.tipo = "Mamífero";
                animal1.tienePatas = true;
                animal1.esDomestico = false;
                animal1.esHerbivoro = true;
                animal1.esCarnivoro = false;

                Vertebrado animal2 = new Vertebrado();
                animal2.nombre = "Serpiente";
                animal2.color = "Verde";
                animal2.tamano = 2.5f;
                animal2.familia = "Serpentes";
                animal2.tipo = "Reptil";
                animal2.tienePatas = false;
                animal2.esDomestico = false;
                animal2.esHerbivoro = false;
                animal2.esCarnivoro = true;

                Invertebrado animal3 = new Invertebrado();
                animal3.nombre = "Mariposa";
                animal3.color = "Azul";
                animal3.tamano = 0.05f;
                animal3.familia = "Lepidopteros";
                animal3.tipo = "Insecto";
                animal3.tienePatas = true;
                animal3.numeroPatas = 6;
                animal3.tieneConcha = false;

                Invertebrado animal4 = new Invertebrado();
                animal4.nombre = "Caracol";
                animal4.color = "Marrón";
                animal4.tamano = 0.1f;
                animal4.familia = "Helicidae";
                animal4.tipo = "Molusco";
                animal4.tienePatas = true;
                animal4.numeroPatas = 1;
                animal4.tieneConcha = true;


                Console.WriteLine("\nDatos del primer vertebrado:");
                animal1.imprimir();

                Console.WriteLine("\nDatos del segundo vertebrado:");
                animal2.imprimir();

                Console.WriteLine("\nDatos del primer invertebrado:");
                animal3.imprimir();

                Console.WriteLine("\nDatos del segundo invertebrado:");
                animal4.imprimir();

                Console.ReadKey();
            }
        }
    }

