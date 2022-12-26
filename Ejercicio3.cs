namespace BusquedaSecuencial;
class Program
{
    static void Main(string[] args)
    {
        int exitos = 0, fallos = 0;
        // Se iniciliza el vectory se le dan valores aleatorios.
        Random random = new Random();
        int[] A = new int[100];
        for (int i = 0; i < A.Length; i++)
        {
            //Número aleatorio entre 1 y 200
            A[i] = random.Next(1, 201);
        }

        Console.WriteLine();

        // Realizar la búsqueda de 50 enteros seleccionados aleatoriamente 
        for (int i = 0; i < 50; i++)
        {
            int rand_number = random.Next(1, 201);
            Console.Write(rand_number + " ");
            if (BusquedaSecuencial(A, rand_number))
            {
                exitos++;
            }
            else
            {
                fallos++;
            }

        }


        // Busquedas exitosas y fallidas
        Console.WriteLine($"\n\nBusquedas Exitosas: {exitos}");
        Console.WriteLine($"Busquedas Fallidas: {fallos}");

        // Porcentaje de exitos y fallos
        Console.WriteLine($"\n\nEl porcentaje de exitos es: {(exitos * 100) / 50}%");
        Console.WriteLine($"El porcentaje de fallos es: {(fallos * 100) / 50}%");
        
        Console.WriteLine("\nArreglo Ordenado");
        Array.Sort(A);
        printArray(A);
        
    }

    static Boolean BusquedaSecuencial(int[] A, int x)
    {
        int i = 0;
        while (i < A.Length)
        {
            if (A[i] == x)
            {
                return true;
            }
            else
            {
                i++;
            }
        }
        return false;
    }

    static void printArray(int[] A){
        for(int i=0; i<A.Length; i++){
            Console.Write(A[i]+" ");
        }
    }
}
