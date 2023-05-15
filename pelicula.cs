public abstract class Pelicula {
    protected string nombre;
    protected int anyo;

    public Pelicula(string nombre, int anyo) {
        this.nombre = nombre;
        this.anyo = anyo;
    }

    public abstract string Descripcion();
}
