namespace TP_5_Polymorphisme;

internal class Garage
{//Liste pour ranger les voitures en cours de réparation:
    private List<Véhicule> véhicules = new List<Véhicule>();
    private string Name { get; set; }
    private int SiretNumber { get; set; }
    /// <summary>
    /// Méthode pour afficher les voitures en curs de réparation.
    /// </summary>
    /// <param></param>
    public void addVehiculesInReparation(Véhicule v)
    {

        if (v.inReparation == true)
        {
            véhicules.Add(v);
            Console.WriteLine($"Le véhicule {v.Name}");
        }
    }
    public void PrintList()
    {
        Console.WriteLine("Véhicules en réparation:");
        for (int i = 0; i < véhicules.Count; i++)
        {
            Console.WriteLine($"|{v}|");
        }
    }

    public Garage(string Name, int siretNumber)
    {
        Name = Name;
        SiretNumber = siretNumber;
    }/// <summary>
     /// Méthode qui supprime un véhicule de la liste du garage.
     /// </summary>
     /// <param name="véhicule"></param>
    public void removeToGarageList(Véhicule véhicule)
    {
        véhicules.Remove(véhicule);
    }
}



