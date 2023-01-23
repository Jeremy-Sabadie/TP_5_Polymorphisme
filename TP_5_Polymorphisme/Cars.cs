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
        private List<Garagist> garagists { get; set; } = new List<Garagist>();

        /// <summary>
        /// Méthode de calcul du temps de réparation spécifique à truck:
        /// </summary>
        /// <returns></returns>
        public override double ReparationTime()
        {
            double Time = 1.5 * Dommage * (Garagist.Skills / 100f);
            return Time;
        }/// <summary>
         /// Affiche le garagiste en charge du véhicule.
         /// </summary>
         /// <param name="v"></param>
        public override void isTheMecanic(Garagist G)
        {
            garagists.Add(G);
            //Console.WriteLine($"Le garagiste en charge du véhicule est:{G._Name}");
        }

    }


}