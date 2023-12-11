using System.Security.Cryptography.X509Certificates;

namespace ExamenDos
{
    public class Mercado
    {
       

        private Nodo Primero;

        public void insertar(string nombre, int precio)
        {
            Nodo nuevo = new Nodo
            {
                Nombre = nombre,
                Precio = precio,
            };


            if(Primero == null)
            {
                Primero = nuevo;

            }
            else 
            { 
                Nodo Actual = Primero;

                while(Actual.Siguiente != null) 
                { 
                        
                    Actual = Actual.Siguiente;
                }
                Actual.Siguiente = nuevo;
            
            }

            Console.WriteLine("Nodo Ingresado");
        }

        public void MostrarDatos()
        {
            Nodo Actual = Primero;
            while (Actual != null) 
            {
                Console.WriteLine($"Nombre: {Actual.Nombre}, Precio: {Actual.Precio}. ");
                Actual = Actual.Siguiente;
            }
        }

        public void OrdenarPrecio()
        {
            Nodo actual;
            Nodo siguiente;

            for(actual = Primero; actual != null; actual= actual.Siguiente)
            {
                for(siguiente = actual.Siguiente; siguiente != null; siguiente = siguiente.Siguiente)
                {
                    if (actual.Precio < siguiente.Precio )
                    {
                        int tempPrecio = actual.Precio;
                        actual.Precio= siguiente.Precio;
                        siguiente.Precio= tempPrecio;

                        string tempNombre = actual.Nombre;
                        actual.Nombre = siguiente.Nombre;
                        siguiente.Nombre= tempNombre;
                    }
                }
            }

    

        }


        public void BuscarPrecio(string PrecioBuscado)
        {
            Nodo Actual = Primero;

            int Posocion = 0;
            bool Encontrado = false;

            while(Actual!= null)
            {

                if (Actual.Precio == int.Parse(PrecioBuscado)) 
                {
                    Console.WriteLine($"El precio{PrecioBuscado} se encuentra {Actual.Precio} en la posicion {Posocion}: de la lista ");
                    Encontrado= true;
                }
                Actual= Actual.Siguiente;
                Posocion++;

        
            }

            if (!Encontrado)
            {
                Console.WriteLine($"El precion no se encuentra {PrecioBuscado}");

            }
        }
    }
}
