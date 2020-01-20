using AbstractFactory.Servicio.Implementacion.Factory;
using AbstractFactory.Servicio.Interfaz;
using System;

namespace AbstractFactory.Controlador
{
    public class Cliente
    {
        public void Main()
        {   
            Console.WriteLine("Cliente: Windows");
            MetodoCliente(new WinFactiory());
            Console.WriteLine();

            Console.WriteLine("Cliente: Mac");
            MetodoCliente(new MacFactory());

            Console.ReadLine();
        }

        public void MetodoCliente(IFactory _Ifactory)
        {
            var productA = _Ifactory.CrearBoton();
            var productB = _Ifactory.CrearCheckBox();

            Console.WriteLine(productA.CrearBotton());
            Console.WriteLine(productB.CrearCheckBox());
        }
    }
}
