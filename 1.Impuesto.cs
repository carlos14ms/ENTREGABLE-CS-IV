Console.WriteLine("INGRESE EL VALOR RECIBIDO EN EL 1 TRIMESTRE DEL AÑO");
int primertrimestre = Int32.Parse(Console.ReadLine());

Console.WriteLine("INGRESE EL VALOR RECIBIDO EN EL 2 TRIMESTRE DEL AÑO");
int segundotrimestre = Int32.Parse(Console.ReadLine());

Console.WriteLine("INGRESE EL VALOR RECIBIDO EN EL 3 TRIMESTRE DEL AÑO");
int tercertrimestre = Int32.Parse(Console.ReadLine());

Console.WriteLine("INGRESE EL VALOR RECIBIDO EN EL 4 Y ULTIMO TRIMESTRE DEL AÑO");
int cuartotrimestre = Int32.Parse(Console.ReadLine());

int rentaanual = primertrimestre + segundotrimestre + tercertrimestre + cuartotrimestre;
if (rentaanual < 10000)
{
    string porcentaje = "5%";
    double impuesto_agregrado = 0.05;
    double rentapagar = rentaanual * impuesto_agregrado;
    Console.WriteLine($"su renta anual es: ({rentaanual}) con un total de renta a pagar por: {rentapagar} y un impuesto agregado de: {porcentaje} porciento");
}
if (rentaanual >= 10000 && rentaanual <20000)
{
    string porcentaje = "10%";
    double impuesto_agregrado = 0.10;
    double rentapagar = rentaanual * impuesto_agregrado;
    Console.WriteLine($"su renta anual es: ({rentaanual}) con un total de renta a pagar por: {rentapagar} y un impuesto agregado de: {porcentaje} porciento");
}
if (rentaanual >= 20000 && rentaanual <35000)
{
    string porcentaje = "15%";
    double impuesto_agregrado = 0.15;
    double rentapagar = rentaanual * impuesto_agregrado;
    Console.WriteLine($"su renta anual es: ({rentaanual}) con un total de renta a pagar por: {rentapagar} y un impuesto agregado de: {porcentaje} porciento");
}
if (rentaanual >= 35000 && rentaanual <45000)
{
    string porcentaje = "20%";
    double impuesto_agregrado = 0.20;
    double rentapagar = rentaanual * impuesto_agregrado;
    Console.WriteLine($"su renta anual es: ({rentaanual}) con un total de renta a pagar por: {rentapagar} y un impuesto agregado de: {porcentaje} porciento");
}
if (rentaanual >= 45000)
{
    string porcentaje = "30%";
    double impuesto_agregrado = 0.30;
    double rentapagar = rentaanual * impuesto_agregrado;
    Console.WriteLine($"su renta anual es: ({rentaanual}) con un total de renta a pagar por: {rentapagar} y un impuesto agregado de: {porcentaje} porciento");
}
