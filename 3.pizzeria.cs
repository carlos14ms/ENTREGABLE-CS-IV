// See https://aka.ms/new-console-template for more information
Console.WriteLine("BIENVENIDOS A PIZZAS FERXXO ☺");
        Console.WriteLine("\n¿Qué tipo de pizza desea? Seleccione con numero \n 1.Vegetariana, \n 2.No Vegetariana)");
        string pizza = Console.ReadLine();

        if (pizza == "1") {
            Console.WriteLine("Ingredientes disponibles: ");
            Console.WriteLine("\n1. Pimiento");
            Console.WriteLine("\n2. Champiñones");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1) {
                Console.WriteLine("Haz Escogido una pizza vegetariana con: \n Mozzarella, Tomate Y pimiento ");
            } else if (opcion == 2) {
                Console.WriteLine("Haz Escogido una pizza Vegetariana con: \n Mozzarella, Tomate Y Champiñones ");
            } 
        } 
        else if (pizza == "2") 
        {
            Console.WriteLine("Ingredientes disponibles:");
            Console.WriteLine("\n 1. Pepperoni");
            Console.WriteLine("\n 2. Salami");
            Console.WriteLine("\n 3. Pollo");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1) {
                Console.WriteLine("Haz Escogido una pizza No Vegetariana con: \n Mozzarella, Tomate Y Pepperoni ");
            } else if (opcion == 2) {
                Console.WriteLine("Haz Escogido una pizza No Vegetariana con: \n Mozzarella, Tomate Y Salami ");
            } else if (opcion == 3) {
                Console.WriteLine("Haz Escogido una pizza No Vegetariana con: \n Mozzarella, Tomate Y Pollo ");
            }
        } else {
            Console.WriteLine("Numero no Valido");
        }
