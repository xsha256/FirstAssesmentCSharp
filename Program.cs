using static System.Console;

Write("Ingrese el nombre de la película: ");
string? nombre = ReadLine();

Write("Ingrese el año de estreno: ");
int anyo = 0;
Int32.TryParse(ReadLine(),out anyo);

WriteLine("Seleccione el género de la película:");
WriteLine("1. Acción");
WriteLine("2. Comedia");
WriteLine("3. Drama");

int opcion = 0;
Int32.TryParse(ReadLine(),out opcion);

Pelicula? pelicula = null;

switch (opcion) {
case 1:
    Write("Ingrese el nombre del protagonista: ");
    string? protagonista = ReadLine();
    pelicula = new Accion(nombre!, anyo, protagonista!);
    break;
case 2:
    Write("Ingrese el nombre del director: ");
    string? director = ReadLine();
    pelicula = new Comedia(nombre!, anyo, director!);
    break;
case 3:
    Write("Ingrese el tema de la película: ");
    string? tema = ReadLine();
    pelicula = new Drama(nombre!, anyo, tema!);
    break;
default:
    WriteLine("Opción inválida.");
    return;
}

if (pelicula!=null)
    WriteLine(pelicula.Descripcion());
Write("Entre cualquier tecla");
ReadKey();
Clear();
