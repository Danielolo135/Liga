namespace eLeagueManager;

public class Equipo 
{
    public string Nombre { get; set; }
    
    private PerfilEstadisticas _stats = new PerfilEstadisticas(); 

    private List<Jugador> _jugadores = new List<Jugador>();

    public void AñadirJugador(Jugador j) 
    {
        _jugadores.Add(j);
    }
}