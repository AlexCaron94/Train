using System;
using System.Collections.Generic;
using System.Text;

namespace Train_Models
{
    public class Lieu
    {
        public string nom { get; set; }
        public ressource ressource { get; set; }
        public int distance { get; set; }
        public int danger { get; set; }
        public int difficulte { get; set; }

        public Lieu(string nom, ressource ressource, int distance, int danger, int difficulte)
        {
            this.nom = nom;
            this.ressource = ressource;
            this.distance = distance;
            this.danger = danger;
            this.difficulte = difficulte;
        }

        public Lieu()
        {
            
        }
    }
}
