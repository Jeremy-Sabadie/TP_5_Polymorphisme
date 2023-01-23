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
        véhicules.Add(v);
    }
    public void PrintList()
    {
        for (int i = 0; i < véhicules.Count; i++)
        {

            Console.WriteLine($@"Véhicules en réparation : {véhicules[i].Name} endommagé à {véhicules[i].Dommage} %:, sera pris en charge par : {véhicules[i].Garagist._Name}
pour un temps estimé à:{véhicules[i].ReparationTime()} heures.");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////");

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
        véhicules.Add(véhicule);
    }
}



