using System;
using System.Collections.Generic;
using System.Text;

namespace Train_Models
{
    public class Expedition
    {
        public Groupe groupe { get; set; }
        public Lieu lieu { get; set; }
        public int ressource { get; set; }
        public int quantite { get; set; }

        public Expedition()
        {
            groupe = new Groupe();
            lieu = new Lieu();
            //quantite max = 5*tailleGroupe
            //penalité distance = distance(lieu) - vitesse(groupe)
            //penalité danger = danger(lieu) - force(groupe)
            //penalité difficulté = difficulte(lieu) - dexterite(groupe)
            //quantité = quantite max - toute les penalité + organisation(groupe)
            
        }
    }
}
