using AbstractFactory.Servicio.Implementacion.Button;
using AbstractFactory.Servicio.Implementacion.CheckBox;
using AbstractFactory.Servicio.Interfaz;

namespace AbstractFactory.Servicio.Implementacion.Factory
{
    class WinFactiory : IFactory
    {
        public IButton CrearBoton()
        {
            return new ButtonWindows();
        }

        public ICheckBox CrearCheckBox()
        {
            return new CheckBoxWindows();
        }
    }
}
