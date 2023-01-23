namespace TP_5_Polymorphisme
{
    internal class Cars : Véhicule

    {
        public Cars(string Name, int dommage, Garagist garagist)
         : base(Name, dommage, garagist)
        {
            Name = Name;
            dommage = dommage;
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
