using TP_5_Polymorphisme;
Garagist G1 = new Garagist("Gérard", "Bouchard", 20);
Véhicule V1 = new Cars("voiture1", 10, G1);
G1.addInList(V1);
Console.WriteLine("liste de voitures du garage:");
G1.printList();