using TP_5_Polymorphisme;

Garage Ga1 = new Garage();
Garagist g1 = new Garagist();
Véhicule v1 = new Véhicule("ff",1,g1);

Ga1.addVehiculesInReparation(v1);