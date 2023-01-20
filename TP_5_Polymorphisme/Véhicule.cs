namespace TP_5_Polymorphisme;

internal class Véhicule
{
    //Attributs de la classe Véhicule:
    public double Dommage { get; private set; }
    public float TimeReparation { get; private set; }
    public Garagist Garagist { get; private set; }
    public bool inReparation = false;
    public string Name { get; set; }

    //Constructeur:
    public Véhicule(string Name, double dommage, float timeReparation, Garagist garagist)
    {
        Dommage = dommage;
        TimeReparation = timeReparation;
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
    public void Print()
    {
        Console.WriteLine(@$"Le véhicule : {véhicule}
avec des dommages évalués à  {Dommage}%, est 
réparé par: {garagist} pour une durée estimé à: {ReparationTime} ");
    }

}
