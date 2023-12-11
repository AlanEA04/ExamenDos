namespace ExamenDos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mercado K = new Mercado();

            for (int i = 0;i <3; i++)
            {
                Console.WriteLine("Ingresa El Nombre del Producto");
                string Producto = Console.ReadLine();

                Console.WriteLine("Ingresa El Precio del Producto");
                int Precio = int.Parse(Console.ReadLine());

                K.insertar(Producto, Precio);



            }

            Console.WriteLine("La Datos Actuales Ingresados son:");
            K.MostrarDatos();

        
            Console.WriteLine("Los datos Ordenados por el Precion en Orden Creciente Son:");
            K.OrdenarPrecio();
            K.MostrarDatos();


            Console.WriteLine("Ingresa El Precio a buscar");
            string PrecioBuscado  = Console.ReadLine();

            K.BuscarPrecio(PrecioBuscado);




            
        }
    }
}