using System;
using System.Collections.Generic;
using System.Text;

namespace Train_Models
{
    public class Groupe
    {
        public List<Personnage> monGroupe = new List<Personnage>();
        public int tailleGroupe { get; set; }
        public int vitesse { get; set; }
        public int force { get; set; }
        public int dexterite { get; set; }
        public int organisation { get; set; }

        public Groupe ()
        {
            //tailleGroupe = List size
            //vitesse = vitesse du personnage le plus lent
            //force = addition de la force de tout les membre du groupe
            //dexterite = moyenne du groupe
            //organisation = organisation du personnage le mieux organisé
            

        }

    }
}
