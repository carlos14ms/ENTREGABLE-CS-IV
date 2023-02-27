// See https://aka.ms/new-console-template for more information
Console.Write("**BIENVENIDO A LA SALA DE VIDEOJUEGOS**");
Console.Write("\nIngrese su nombre:");
string nombre = Console.ReadLine();

Console.Write("Ingrese su edad: ");
int edad = Int32.Parse(Console.ReadLine());

int precioEntrada = 15000;
double descuento = 0;

if (edad<4){
Console.WriteLine($"{nombre},su entrada es gratuita");
return;
}
else if (edad >= 4 && edad <= 18){
descuento = 0.05;
}
else{
 descuento = 0.03;
}
double descuentofinal =  (precioEntrada * descuento);
double precioFinal = (precioEntrada-descuentofinal);

Console.WriteLine( "Hola " +nombre+ " el precio de su entrada es por: " +precioFinal+ " con un descuento por: " +descuento+ " porciento");
