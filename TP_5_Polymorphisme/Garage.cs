namespace TP_5_Polymorphisme;

internal class Garage
{//Liste pour ranger les voitures en cours de réparation:
    private List<Véhicule> véhicules = new List<Véhicule>();
    /// <summary>
    /// Méthode pour afficher les voitures en curs de réparation.
    /// </summary>
    /// <param name="v"></param>
    public void addVehiculesInReparation(Véhicule v)
    {
        if (v.inReparation == true)
        {
            véhicules.Add(v);
            Console.WriteLine($"Le véhicule {v.Name}");
        }
    }

    public void printList()
    {
        Console.WriteLine("Véhicules en réparation:");
        for (int i = 0; i < véhicules.Count; i++)
        {
            Console.WriteLine($"|{véhicules[i].Print}|");
        }
    }


}
