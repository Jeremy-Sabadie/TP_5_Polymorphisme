using TP_5_Polymorphisme;

Garagist G1 = new Garagist("John", "Doe", 50);//Cr�ation du garagiste G1.

V�hicule V1 = new V�hicule("BMW", 10, G1);//Cr�ation du v�hicule V1.

Garage Gr1 = new Garage("Garage n�1", 753951);//Cr�ation du garage Gr1.

V�hicule C1 = new Cars("Voiture n�1", 20, G1);//Cr�ation de l'objet Car C1.

C1.isTheMecanic(G1);//Le garagiste G1 est attribu� � l'ojet C1
Gr1.addVehiculesInReparation(V1);//Ajout de V1 dans la liste de Gr1.
Gr1.PrintList();//Affichage de la liste de Gr1.
//Affichage du garagiste en charge de C1.
//Console.WriteLine($"temps de r�paration de C1 est �gal �: {C1.ReparationTime()}heures");//Affichage du tem de r�paration calcul� par la m�thode d�di�e.

