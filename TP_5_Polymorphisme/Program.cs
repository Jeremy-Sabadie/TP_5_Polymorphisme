using TP_5_Polymorphisme;

Garagist G1 = new Garagist("John", "Doe", 50);
Véhicule V1 = new Véhicule("BMW", 10, G1);
Garage Gr1 = new Garage("Garage n°1", 753951);
Véhicule C1 = new Cars("Voiture n°1", 20, G1);//Création d'un objet Car.
C1.isTheMecanic(G1);
Gr1.addInGarageList(V1);//Ajout de V1 dans la liste de G1.

Gr1.addVehiculesInReparation(V1);//Ajout de V1 dans la liste de Gr1.
Gr1.PrintList(Gr1);//Affichage de la liste de Gr1.
;//Affichage du garagiste en charge de C1.
//Console.WriteLine($"temps de réparation de C1 est égal à: {C1.ReparationTime()}heures");//Affichage du tem de réparation calculé par la méthode dédiée.

