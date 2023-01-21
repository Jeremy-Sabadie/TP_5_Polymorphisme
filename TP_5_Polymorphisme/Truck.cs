﻿namespace TP_5_Polymorphisme
{
    internal class Truck : Véhicule

    {


        public Truck(string Name, double dommage, Garagist garagist)
        : base(Name, dommage, garagist)
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
