using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList list = new CasoList();

        Alumno alu1 = new Alumno(1, "Juan", 8.5);
        Alumno alu2 = new Alumno(2, "Maria", 9.0);
        Alumno alu3 = new Alumno(3, "Pedro", 7.5);

        list.AgregarAlumno(alu1);
        list.AgregarAlumno(alu2);
        list.AgregarAlumno(alu3);

        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine("--- Lista de Alumnos: ");
        foreach (var alumno in list.GetListaAlumnos())
        {
            Console.WriteLine("ID :"+alumno.Id+", Nombre :"+alumno.Nombre+", Promedio :"+alumno.Promedio);
        }

        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine("--- Buscando Alumno por Nombre: Juan");
        var alumnoBuscado = list.BuscarAlumnoPorNombre("Juan");
        if (alumnoBuscado != null)
        {
            Console.WriteLine("ID :"+alumnoBuscado.Id+", Nombre :"+alumnoBuscado.Nombre+", Promedio :"+alumnoBuscado.Promedio );
        }
        else
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine("--- Buscando Alumno por Nombre: Camila");
        Alumno? alumnoBuscado2 = list.BuscarAlumnoPorNombre("Camila");
        if (alumnoBuscado2 != null)
        {
            Console.WriteLine("ID :" + alumnoBuscado2.Id + ", Nombre :" + alumnoBuscado2.Nombre + ", Promedio :" + alumnoBuscado2.Promedio);
        }
        else
        {
            Console.WriteLine("No existe");
        }
        Console.WriteLine("═══════════════════════════════════════");
        list.EliminarAlumno(alu1);
        Console.WriteLine("--- Alumno eliminado: " + alu1.Nombre);
        Console.WriteLine("--- Alumnos restantes: ");
        foreach (var alumno in list.GetListaAlumnos())
        {
            Console.WriteLine("ID :"+alumno.Id+", Nombre :"+alumno.Nombre+", Promedio :"+alumno.Promedio);
        }

        Console.WriteLine("═══════════════════════════════════════");
        list.EliminarAlumnoPorPosicion(0);
        Console.WriteLine("--- Alumno en posicion 0 eliminado");
        Console.WriteLine("--- Alumnos restantes: ");
        foreach (var alumno in list.GetListaAlumnos())
        {
            Console.WriteLine("ID :"+alumno.Id+", Nombre :"+alumno.Nombre+", Promedio :"+alumno.Promedio);
        }
        Console.WriteLine("═══════════════════════════════════════");
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary diccionario = new CasoDictionary();

        Alumno alu1 = new Alumno(60123, "Juan", 8.5);
        Alumno alu2 = new Alumno(60124, "Maria", 9.0);
        Alumno alu3 = new Alumno(60125, "Pedro", 7.5);

        diccionario.AgregarAlumnoDiccionario(alu1);
        diccionario.AgregarAlumnoDiccionario(alu2);
        diccionario.AgregarAlumnoDiccionario(alu3);

        Console.WriteLine("═══════════════════════════════════════");

        Console.WriteLine("--- Lista de Alumnos: ");
        foreach (var alumno in diccionario.GetDiccionarioAlumnos())
        {
            Console.WriteLine("Legajo :"+alumno.Key+", Nombre :"+alumno.Value.Nombre+", Promedio :"+alumno.Value.Promedio);
        }


        Console.WriteLine("═══════════════════════════════════════");

        Console.WriteLine("--- Buscando Alumno por Legajo: 60123");
        Alumno? encontrado = diccionario.BuscarAlumnoPorLegajo(60123);
        if (encontrado != null)
            Console.WriteLine("Alumno encontrado: " + encontrado.Nombre);
        else
            Console.WriteLine("No existe");

        Console.WriteLine("═══════════════════════════════════════");

        Console.WriteLine("--- Buscando Alumno por Legajo: 60111");
        Alumno? encontrado2 = diccionario.BuscarAlumnoPorLegajo(60111);
        if (encontrado2 != null)
            Console.WriteLine("Alumno encontrado: " + encontrado2);
        else
            Console.WriteLine("No existe");

        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine("--- Eliminando alumno con legajo 60124:");
        diccionario.EliminarAlumnoPorLegajo(60124);

        Console.WriteLine("--- Alumnos restantes: ");
        foreach (var alu in diccionario.GetDiccionarioAlumnos())
        {
            Console.WriteLine("Legajo: " + alu.Key + ", Nombre: " + alu.Value.Nombre + ", Promedio: " + alu.Value.Promedio);
        }

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
