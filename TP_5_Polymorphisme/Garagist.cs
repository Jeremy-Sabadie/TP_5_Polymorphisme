namespace TP_5_Polymorphisme;

internal class Garagist
{
    private string Name;
    private string FirstName;
    public float Skills { get; private set; }
    private List<Véhicule> Véhicules;

    public string Name1 { get => Name; set => Name = value; }
    public string FirstName1 { get => FirstName; set => FirstName = value; }
    internal List<Véhicule> Véhicules1 { get => Véhicules; set => Véhicules = value; }
}
