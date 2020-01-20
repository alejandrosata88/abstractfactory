namespace AbstractFactory.Servicio.Interfaz
{
    public interface IFactory
    {
        IButton CrearBoton();

        ICheckBox CrearCheckBox();
    }
}
