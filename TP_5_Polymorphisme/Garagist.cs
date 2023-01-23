namespace TP_5_Polymorphisme;

internal class Garagist
{
    public int Skills { get; private set; }

    public string _Name { get; set; }
    private string _FirstName { get; set; }
    private List<Véhicule> garagists = new List<Véhicule>();
    private List<Véhicule> Véhicules { get; set; } = new List<Véhicule>();

    public Garagist(string name, string FirstName, int skills)
    {
        _Name = name;
        _FirstName = FirstName;
        Skills = skills;
    }
    /// <summary>
    /// Méthode qui ajoute un véhicule dans la liste véhicules du garagiste.
    /// </summary>
    /// <param name="véhicule"></param>
    public void addInList(Véhicule véhicule)
    {
        Véhicules.Add(véhicule);
    }
    /// <summary>
    /// Méthode qui ajoute un véhicule dans la liste véhicules du garagiste.
    /// </summary>
    /// <param name="véhicule"></param>
    public void removeToList(Véhicule véhicule)
    {
        Véhicules.Remove(véhicule);
    }
}
