namespace MiCli;

// TODO: Crea un programa que imprima tu Nombre, Carrera y Hobby favorito en líneas separadas
public class Ejercicio1_Presentacion
{
    public static string ObtenerPresentacion()
    {
        // TODO: Declara tres variables string: nombre, carrera y hobby
        string nombre = "Jostin";
        string carrera = "Desarrollo de software";
        string hobby = "Escuchar musica y leer revistas tecnologicas";
        
<<<<<<< HEAD
string nombre = "Jostin ";
string carrera = "Desarollo de software ";
string hoobie = "Escuchar musica y leer revistas tecnologicas";
string resultado = "Mi nombre es " + nombre  +  "\n Mi carrera es " + carrera + " \n Mi Hobbie es " + hoobie;
        // TODO: Retorna un string con las tres variables en líneas separadas
        return resultado; //OJO: reemplaza este texto
        throw new NotImplementedException();
=======
        // TODO: Retorna un string con las tres variables en líneas separadas
        return nombre + "\n" + carrera + "\n" + hobby;
>>>>>>> 5f326f79e5395ff6a01355cbc2e2dc867c534dd5
    }
    
    public static void Ejecutar()
    {
        Console.WriteLine(ObtenerPresentacion());
    }
}
