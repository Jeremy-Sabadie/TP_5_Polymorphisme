namespace TP_5_Polymorphisme;

internal class Garagist
{
    public int Skills { get; private set; }
    private string _Name { get => _Name; set => _Name = value; }
    private string _FirstName { get => _FirstName; set => _FirstName = value; }
    private List<Véhicule> garagists = new List<Véhicule>();
    private List<Véhicule> Véhicules { get => Véhicules; set => Véhicules = value; }

    public Garagist(string Name, string FirstName, int Skills)


    {
        _Name = Name;
        _FirstName = FirstName;
        Skills = Skills;
    }/// <summary>
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
