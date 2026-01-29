namespace MiCli;

// TODO: Crea un programa que imprima tu Nombre, Carrera y Hobby favorito en líneas separadas
public class Ejercicio1_Presentacion
{
    public static string ObtenerPresentacion()
    {
     
        string nombre = "Jostin";
        string carrera = "Desarrollo de software";
        string hobby = "Escuchar música y leer revistas tecnológicas";

      
        return "Mi nombre es " + nombre +
               "\nMi carrera es " + carrera +
               "\nMi hobby es " + hobby;
    }

    public static void Ejecutar()
    {
        Console.WriteLine(ObtenerPresentacion());
    }    

}
