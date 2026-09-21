namespace PilasArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilas pila = new Pilas(10);

            pila.Agregar("A");
            pila.Agregar("B");
            pila.Agregar("C");

            Console.WriteLine(pila.ObtenerDatos());

            pila.Agregar("D");
            Console.WriteLine(pila.ObtenerDatos());

            pila.Eliminar();
            Console.WriteLine(pila.ObtenerDatos());

            pila.Eliminar();
            Console.WriteLine(pila.ObtenerDatos());
        }
    }
}
