namespace TP_5_Polymorphisme
{
    internal class Truck : Véhicule
    {
        private string Name;
        private int _Dammage;
        private Garagist garagist;
        public Truck(string Name, int dommage, float timeReparation, Garagist garagist)
        : base(Name, dommage, garagist)
        {
            Name = Name;
            dommage = dommage;
            garagist = garagist;
        }

        /// <summary>
        /// Méthode de calcul du temps de réparation spécifique à truck:
        /// </summary>
        /// <returns></returns>
        public override double ReparationTime()
        {
            double Time = 2 * Dommage * (Garagist.Skills / 100);
            return Time;
        }
    }
}
