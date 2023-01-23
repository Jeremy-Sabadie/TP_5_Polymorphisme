namespace TP_5_Polymorphisme;

internal class Véhicule
{
    //Attributs de la classe Véhicule:
    public int Dommage { get; private set; }

    public Garagist Garagist { get; private set; }
    public bool inReparation = false;
    public string Name { get; set; }
    private List<Garagist> garagists = new List<Garagist>();

    //Constructeur:
    public Véhicule(string Name, int dommage, Garagist garagist)
    {
        Dommage = dommage;
        Garagist _garagist = garagist;


    }


    /// <summary>
    /// Méthode ReparationTime pour le calcul du temps de réparation du véhicule:
    /// </summary>
    /// <returns></returns>
    public virtual double ReparationTime()
    {
        double Time = 1.5 * Dommage * (Garagist.Skills / 100);
        return Time;
    }
    public void Print(Garagist g
        )
    {
        Console.WriteLine(@$"Le véhicule : |{Name}|
avec des dommages évalués à  |{Dommage}%|, est 
réparé par: |{g.Name} |pour une durée estimé à: |{ReparationTime}|");
    }

}
