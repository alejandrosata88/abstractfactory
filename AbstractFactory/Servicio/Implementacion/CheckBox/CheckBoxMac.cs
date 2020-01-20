using AbstractFactory.Servicio.Interfaz;

namespace AbstractFactory.Servicio.Implementacion.CheckBox
{
    public class CheckBoxMac : ICheckBox
    {
        public string CrearCheckBox()
        {
            return "Crea checkbox en mac";
        }
    }
}
