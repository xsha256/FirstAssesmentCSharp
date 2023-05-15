public class Comedia : Pelicula {
    private string director;

    public Comedia(string nombre, int anyo, string director) : base(nombre, anyo) {
        this.director = director;
    }

    public override string Descripcion() {
        return $"La comedia '{nombre}', estrenada en {anyo}, fue dirigida por {director}. Es una película divertida y con un buen sentido del humor.";
    }
}