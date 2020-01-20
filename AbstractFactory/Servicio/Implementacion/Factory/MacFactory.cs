using AbstractFactory.Servicio.Implementacion.Button;
using AbstractFactory.Servicio.Implementacion.CheckBox;
using AbstractFactory.Servicio.Interfaz;

namespace AbstractFactory.Servicio.Implementacion.Factory
{
    public class MacFactory : IFactory
    {
        public IButton CrearBoton()
        {
            return new ButtonMac();
        }

        public ICheckBox CrearCheckBox()
        {
            return new CheckBoxMac();
        }
    }
}
