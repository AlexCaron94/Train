using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Train_Models;

namespace Train_WPF
{
    public partial class MainWindow : Window
    {
        private ICollection<Expedition> expeditions = new List<Expedition>();
        public MainWindow()
        {
            InitializeComponent();
            Character_Pam.Tag = new Personnage("Pam",2,2,2,2) ;
            Character_Xef.Tag = new Personnage("Xef", 2, 2, 2, 2);
            Character_Popy.Tag = new Personnage("Popy", 2, 2, 2, 2);
            Area_OilWell.Tag = new Lieu("OilWell", ressource.gas, 2, 2, 2);
        }

        //Pour drag un personnage
        private void CharacterMouseMove(object sender, MouseEventArgs e)
        {
            //On recupère l'objet qu'on drag et on le rentre dans la variable
            //On vérifie qu'on clique et qu'on a bien une image avec un tag personnage, alors on autorise le drag

            Image image = sender as Image;
            if (image != null && e.LeftButton == MouseButtonState.Pressed && image.Tag !=null && image.Tag is Personnage tag)
            {
                DragDrop.DoDragDrop(image, tag, DragDropEffects.Move);
            }
        }

        //Lorsqu'on passe sur le lieu pour drop personnage
        private void AreaDragEnter(object sender, DragEventArgs e)
        {
            //

        }

        //Lorsqu'on drop un personnage
        private void AreaDrop(object sender, DragEventArgs e)
        {
            //Si on a bien une image avec un tag lieu
            //On recupere les data de l'objet qu'on drop
            //On cherche si il existe une expedition avec le même lieu que l'object sender dans la liste "expeditions"
            //Si elle n'existe pas on en créer une et on l'ajoute à la liste "expeditions"
            //On cherche si il y'a déjà un perso dans l'expedition avec le même nom que celui qu'on drop
            //Si ce n'est pas le cas on l'ajoute au groupe de l'expedition

            if (sender is Image image && image.Tag != null && image.Tag is Lieu lieu)
            {
                Personnage personnage = e.Data.GetData(typeof(Personnage)) as Personnage;
                if (personnage !=null)
                {
                    var expedition = expeditions.Where(x => x.lieu.nom == lieu.nom).SingleOrDefault();
                    if (expedition == null)
                    {
                        expedition = new Expedition() {lieu = lieu };
                        expeditions.Add(expedition);
                    }
                    if (expedition.groupe.monGroupe.Any(x => x.nom == personnage.nom))
                    { }
                    else
                    {
                        expedition.groupe.monGroupe.Add(personnage);
                    }
                }
            }

        }
    }
}
