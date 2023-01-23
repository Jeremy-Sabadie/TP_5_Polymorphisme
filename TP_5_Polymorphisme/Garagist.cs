namespace TP_5_Polymorphisme;

internal class Garagist
{
    private string _Name;
    private string _FirstName;
    public int Skills { get; private set; }
    private List<Véhicule> garagists = new List<Véhicule>();

    public string Name { get => _Name; set => _Name = value; }
    public string FirstName { get => _FirstName; set => _FirstName = value; }
    private List<Véhicule> Véhicules { get => Véhicules; set => Véhicules = value; }
    public Garagist(string Name, string FirstName, int Skills)
    {
        _Name = Name;
        _FirstName = FirstName;
        Skills = Skills;
    }
    public void addInList(Véhicule véhicule)
    {
        Véhicules.Add(véhicule);
    }
}
