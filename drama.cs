public class Drama : Pelicula {
    private string tema;

    public Drama(string nombre, int anyo, string tema) : base(nombre, anyo) {
        this.tema = tema;
    }

    public override string Descripcion() {
        return $"La película dramática '{nombre}', estrenada en {anyo}, trata el tema de {tema}. Es una película emotiva y profunda.";
    }
}