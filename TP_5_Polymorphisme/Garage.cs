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
    public void PrintList(Garage G)
    {

        for (int i = 0; i < véhicules.Count; i++)
        {
            Console.WriteLine($"////////////////////////////////////////////////////////////////////////////////////////////");

            Console.WriteLine($@"Véhicules en réparation: {véhicules[i].Name} et sont garagiste est: {véhicules[i].Garagist}
pour un temps estimé à: véhicules[i].ReparationTime()");
            Console.WriteLine($"////////////////////////////////////////////////////////////////////////////////////////////");

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
    public void addInGarageList(Véhicule véhicule)
    {
        véhicules.Remove(véhicule);
    }
}



