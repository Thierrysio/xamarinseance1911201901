using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamarinseance1911201901.VuesModeles;

namespace xamarinseance1911201901.Vues
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjetPage : ContentPage
    {
        public ProjetPage()
        {
            InitializeComponent();
            BindingContext = new ProjetVueModele();
        }
    }
}