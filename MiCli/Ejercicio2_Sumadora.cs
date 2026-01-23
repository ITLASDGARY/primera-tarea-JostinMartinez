namespace MiCli;

// TODO: Declara dos variables int con valores fijos, súmalas y muestra el resultado
public class Ejercicio2_Sumadora
{
    public static int Sumar(int a, int b)
    {
        // TODO: Implementa la suma de a y b

        int resultado = b + a;
        return  resultado; //OJO: reemplaza este texto con el resultado de la suma
        throw new NotImplementedException();
    }
    
    public static string ObtenerResultado()
    {
        // TODO: Declara dos variables int con valores fijos
              int a = 1;
       int  b=2 ;
       int resultado = a + b;
        // TODO: Implementa la suma de a y b, y guarda el resultado
        // TODO: Retorna el texto "La suma es: X" donde X es el resultado
       return "La suma es: " + resultado;//OJO: reemplaza este texto
        throw new NotImplementedException();
    }
    
    public static void Ejecutar()
    {
        Console.WriteLine(ObtenerResultado());
        Console.WriteLine(Sumar(1,2));
    }
}
