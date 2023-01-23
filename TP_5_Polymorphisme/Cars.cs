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
            double Time = 1.5 * Dommage * (Garagist.Skills / 100);
            return Time;
        }/// <summary>
         /// Affiche le garagiste en charge du véhicule.
         /// </summary>
         /// <param name="v"></param>
        public void isTheGaragist(Véhicule v)
        {
            Console.WriteLine($"Lgaragiste en charge du véhicule est:{v.Garagist}");
        }
    }
}
