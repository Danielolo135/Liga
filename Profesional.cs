namespace eLeagueManager;

public class Profesional : Jugador, IEntrevistable 
{
    public double Sueldo { get; set; }
    public string Patrocinador { get; set; }

    public void RealizarDeclaraciones() 
    {
        Console.WriteLine($"{Alias} dice: 'Dimos el 100%'");
    }
}