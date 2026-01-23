namespace MiCli;

// TODO: Crea un programa que imprima tu Nombre, Carrera y Hobby favorito en líneas separadas
public class Ejercicio1_Presentacion
{
    public static string ObtenerPresentacion()
    {
        // TODO: Declara tres variables string: nombre, carrera y hobby
        
string nombre = "Jostin ";
string carrera = "Desarollo de software ";
string hoobie = "Escuchar musica y leer revistas tecnologicas";
string resultado = "Mi nombre es " + nombre  +  "\n Mi carrera es " + carrera + " \n Mi Hobbie es " + hoobie;
        // TODO: Retorna un string con las tres variables en líneas separadas
        return resultado; //OJO: reemplaza este texto
        throw new NotImplementedException();
    }
    
    public static void Ejecutar()
    {
        Console.WriteLine(ObtenerPresentacion());
    }
}
