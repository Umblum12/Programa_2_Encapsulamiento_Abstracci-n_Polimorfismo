using Programa_2_Encapsulamiento_Abstracción_Polimorfismo;

namespace Programa_2_Encapsulamiento_Abstracción_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
          Leon leon = new Leon();
            Console.WriteLine("Leon");
            Console.WriteLine("Ingrese nombre del Animal: ");
            leon.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el total de patas del Animal: ");
            leon.Total_patas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese sonido  emitido del Animal: ");
            leon.Sonido_emitido = Console.ReadLine();
            Console.WriteLine("Ingrese donde duerme del Animal: ");
            leon.Dormir1 = Console.ReadLine();
            Console.WriteLine("nombre: " + leon.Nombre + " " + "Total de patas: " +leon.Total_patas + " " + "Sonido que emite: " + leon.Sonido_emitido + " " + "Donde Duerme: " + leon.Dormir1);
            Oso oso = new Oso();
            Console.WriteLine("Oso");
            Console.WriteLine("Ingrese nombre del Animal: ");
            oso.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el total de patas del Animal: ");
            oso.Total_patas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese sonido  emitido del Animal: ");
            oso.Sonido_emitido = Console.ReadLine();
            Console.WriteLine("Ingrese donde duerme del Animal: ");
            oso.Dormir1 = Console.ReadLine();
            Console.WriteLine("nombre: " + oso.Nombre + " " + "Total de patas: " + oso.Total_patas + " " + "Sonido que emite: " + oso.Sonido_emitido + " " + "Donde Duerme: " + oso.Dormir1);
            Tigre tigre = new Tigre();
            Console.WriteLine("Tigre");
            Console.WriteLine("Ingrese nombre del Animal: ");
            tigre.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el total de patas del Animal: ");
            tigre.Total_patas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese sonido  emitido del Animal: ");
            tigre.Sonido_emitido = Console.ReadLine();
            Console.WriteLine("Ingrese donde duerme del Animal: ");
            tigre.Dormir1 = Console.ReadLine();
            Console.WriteLine("nombre: " + tigre.Nombre + " " + "Total de patas: " + tigre.Total_patas + " " + "Sonido que emite: " + tigre.Sonido_emitido + " " + "Donde Duerme: " + tigre.Dormir1);
            Console.ReadKey(true);
        }
    }
}