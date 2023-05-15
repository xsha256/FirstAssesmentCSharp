public class Accion : Pelicula {
    private string protagonista;

    public Accion(string nombre, int anyo, string protagonista) : base(nombre, anyo) {
        this.protagonista = protagonista;
    }

    public override string Descripcion() {
        return $"La película de acción '{nombre}', estrenada en {anyo}, cuenta con el protagonismo de {protagonista}. Es una película emocionante y llena de acción.";
    }
}