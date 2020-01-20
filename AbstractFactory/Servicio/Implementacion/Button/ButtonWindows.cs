using AbstractFactory.Servicio.Interfaz;

namespace AbstractFactory.Servicio.Implementacion.Button
{
    public class ButtonWindows : IButton
    {
        public string CrearBotton()
        {
            return "Crea boton en mac";
        }
    }
}
