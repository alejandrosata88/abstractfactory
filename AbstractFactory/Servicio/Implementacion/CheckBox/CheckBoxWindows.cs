using AbstractFactory.Servicio.Interfaz;

namespace AbstractFactory.Servicio.Implementacion.CheckBox
{
    public class CheckBoxWindows : ICheckBox
    {
        public string CrearCheckBox()
        {
            return "Crea checkbox en windows";
        }
    }
}
