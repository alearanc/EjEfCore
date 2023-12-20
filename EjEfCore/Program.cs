using EjEfCore.DataAccess;
using EjEfCore.Domain;
using Microsoft.EntityFrameworkCore;

var context = new AcademiaDbContext();

var estudiantes = await context.Estudiantes.ToListAsync();
WriteToConsole(estudiantes);


context.Dispose();

static void WriteToConsole(IEnumerable<Estudiante> estudiantes)
{
    foreach (Estudiante estudiante in estudiantes)
    {
        string json = System.Text.Json.JsonSerializer.Serialize(estudiante);
        Console.WriteLine(json);    
    }
}