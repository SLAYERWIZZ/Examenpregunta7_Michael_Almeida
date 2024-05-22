//Cree un programa que permita definir una clase base <<Pais>> que sea abstracta.
//Debe heredar sus métodos a <<Ecuador>>, <<Brasil>>, <<Andorra>>
//En el main. Muestre el color de la bandera de Ecuador, el Tamaño de Andorra y el Idioma de Brasil 

using System;

abstract class Pais
{
    public abstract string ColorBandera();
    public abstract string Tamaño();
    public abstract string Idioma();
}

// Clase Ecuador que hereda de Pais
class Ecuador : Pais
{
    public override string ColorBandera()
    {
        return "Amarillo, azul y rojo";
    }

    public override string Tamaño()
    {
        return "283,561 km²";
    }

    public override string Idioma()
    {
        return "Español";
    }
}

// Clase Brasil que hereda de Pais
class Brasil : Pais
{
    public override string ColorBandera()
    {
        return "Verde y amarillo";
    }

    public override string Tamaño()
    {
        return "8.511.965km²";
    }

    public override string Idioma()
    {
        return "Portugués";
    }
}

// Clase Andorra que hereda de Pais
class Andorra : Pais
{
    public override string ColorBandera()
    {
        return "Azul, amarillo y rojo";
    }

    public override string Tamaño()
    {
        return "468 km²";
    }

    public override string Idioma()
    {
        return "Catalán";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creación de instancias de cada país
        Ecuador ecuador = new Ecuador();
        Brasil brasil = new Brasil();
        Andorra andorra = new Andorra();

        // Mostrar información de cada país
        Console.WriteLine("Color de la bandera de Ecuador: " + ecuador.ColorBandera());
        Console.WriteLine("Tamaño de Andorra: " + andorra.Tamaño());
        Console.WriteLine("Idioma oficial de Brasil: " + brasil.Idioma());
    }
}
