Console.Write("INGRESE LA PUNTUACION DEL EMPLEADO: \n 1: 0.0 \n 2: 0.4 \n 3: 0.6  ");
           string opcion = (Console.ReadLine());

            if (opcion == "1")
            {

               double puntuacion = 0.0;
               string nivel = "Inaceptable";
               double bonificacion = puntuacion * 50000;
               Console.WriteLine("Nivel de evaluación: " + nivel);
               Console.WriteLine("El Empleado no obtiene Bonificacion por su baja puntuacion ");
            }
            else if (opcion == "2")
            {
              
                double puntuacion = 0.4;
                string nivel = "Aceptable";
                double bonificacion = puntuacion * 50000;
                Console.WriteLine("Nivel de evaluación: " + nivel);
                Console.WriteLine("Bonificación ganada: " + bonificacion);
            }
            else if (opcion == "3")
            {
                double puntuacion = 0.6;
                string nivel = "Meritorio";
                double bonificacion = puntuacion * 50000;
                Console.WriteLine("Nivel de evaluación: " + nivel);
                Console.WriteLine("Bonificación ganada: " + bonificacion);
            }
            else
            {
                Console.WriteLine("¡Eror! la opcion ingresada no esta entre las cifras mencionadas");
                
            }
