using AbstractFactory.Servicio.Interfaz;

namespace AbstractFactory.Servicio.Implementacion.Button
{
    public class ButtonMac : IButton
    {
        public string CrearBotton()
        {
            return "Crea boton en windows";
        }
    }
}
