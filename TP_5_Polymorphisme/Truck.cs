namespace TP_5_Polymorphisme
{
    internal class Truck : Véhicule

    {
        public Truck(double dommage, float timeReparation, Garagist garagist)
        : base(dommage, timeReparation, garagist)
        {

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
