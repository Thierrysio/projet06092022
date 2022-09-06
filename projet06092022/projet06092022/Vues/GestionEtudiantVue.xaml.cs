using projet06092022.VueModeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projet06092022.Vues
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GestionEtudiantVue : ContentPage
    {
        // 1 - initialialisation de l'attribut vuemodele
        GestionEtudiantVueModele vueModele;

        public GestionEtudiantVue()
        {
            InitializeComponent();
            // 2 - instantiation de l'objet et liaison entre la vue et la vuemodele
            BindingContext = vueModele = new GestionEtudiantVueModele();


        }
    }
}