using FacturacionApp_412194.Entities;
using FacturacionApp_412194.Services;

bool continuar = true;
bool valido;
int eleccion;
int idFactura;

while (continuar)
{
    Console.WriteLine("Que desea hacer? \n\t1) Ver Toda Factura\n\t2) Ver una Factura por su numero\n\t3) Crear una factura\n\t4)Salir");
    eleccion = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    switch (eleccion)
        {
            case 1:
            List<Factura> lista = FacturacionManager.GetEveryFactura();
                foreach (Factura f in lista)
                {
                    Console.WriteLine(f.ToString());
                }
                ;
                break;
            case 2:
                valido = false;
                while (!valido)
                {
                    Console.WriteLine("Ingrese el numero de factura: ");
                    try
                    {
                        idFactura = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (FacturacionManager.GetOneFactura(idFactura) != null) 
                        {
                            Console.WriteLine(FacturacionManager.GetOneFactura(idFactura).ToString());
                        }
                        else
                        {
                            Console.WriteLine("No hay ningna factura con ese numero!");
                        }
                        valido = true;
                    }
                    catch
                    {
                        Console.WriteLine("Ingrese un numero de factura valido!");
                        valido = false;
                    }
                }
                break;
            case 3:
            if (FacturacionManager.CreateFactura())
            {
                Console.WriteLine("Factura creada");
            }
            else
            {
                Console.WriteLine("Algo fallo");
            }
                break;
            case 4:
                continuar = false;
                break;
            default:
                Console.WriteLine("Elija una opcion valida!");
                break;
        }
}