using reto_bloaters;

class Program
{
    static void Main()
    {
        Restaurante restaurante = new Restaurante("El Buen Sabor", "123 Calle Principal");
        restaurante.AgregarMesero("Juan");
        restaurante.AgregarMesero("Ana");
        restaurante.AgregarCocinero("Carlos");
        restaurante.AgregarCocinero("Luis");
        restaurante.AgregarPlatillo("Ensalada", 5, 10);
        restaurante.AgregarPlatillo("Pizza", 8, 15);
        restaurante.GenerarReporteRestaurante();
    }
}