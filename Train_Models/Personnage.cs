using System;
using System.Collections.Generic;
using System.Text;

namespace Train_Models
{
    public class Personnage
    {
        public string nom { get; set; }
        public int vitesse { get; set; }
        public int force { get; set; }
        public int dexterite { get; set; }
        public int organisation { get; set; }

        public Personnage()
        {

        }
        
        public Personnage(string nom, int vitesse, int force, int dexterite, int organisation)
        {
            this.nom = nom;
            this.vitesse = vitesse;
            this.force = force;
            this.dexterite = dexterite;
            this.organisation = organisation;
        }
    }
}
