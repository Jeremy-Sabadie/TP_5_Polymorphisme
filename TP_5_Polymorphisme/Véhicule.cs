namespace TP_5_Polymorphisme
{
    internal class Véhicule
    {//Attributs de la classe Véhicule:
        private double Dommage;
        private float TimeReparation;
        private string Garagist;
        //Constructeur:
        public Véhicule(double dommage, float timeReparation, string garagist)

        {

            Dommage = dommage;
            TimeReparation = timeReparation;
            Garagist = garagist;
        }

        //Accesseurs d'attributs:
        public double Dommage1 { get => Dommage; set => Dommage = value; }
        public float TimeReparation1 { get => TimeReparation; set => TimeReparation = value; }
        public string Garagist1 { get => Garagist; set => Garagist = value; }
        public float ReparationTime()
        {
            float Time = 1.5 * Dommage * (Garagist.Skills / 100);
            return Time;
        }

    }
}
