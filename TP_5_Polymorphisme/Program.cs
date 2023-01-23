using TP_5_Polymorphisme;

Garagist G1 = new Garagist("Gérard", "Bouchard", 50);
Véhicule V1 = new Véhicule("BMW", 10, G1);
Garage GarageGr1 = new Garage("Garage n°1", 753951);
Cars C1 = new Cars("Voiture n°1", 20, G1);//Création d'un objet Car.
G1.addInList(V1);//Ajout de V1 dans la liste de G1.

GarageGr1.addVehiculesInReparation(V1);//Ajout de V1 dans la liste de Gr1.
GarageGr1.PrintList();//Affichage de la liste de Gr1.
C1.isTheGaragist(C1);//Affichage du garagiste en charge de C1.
Console.WriteLine($"temps de réparation de C1={C1.ReparationTime}");//Affichage du tem de réparation calculé par la méthode dédiée.

