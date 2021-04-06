using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppListView.Model;    

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class entrada_visitante : ContentPage
    {
        public Visitante umVisitante = new Visitante();
        public entrada_visitante()
        {
            InitializeComponent();
            umVisitante.Id = ++App.ultimoId;
            umVisitante.End_image = "frame.jpeg";
            BindingContext = umVisitante;
        
        }

        private void gravar_Clicked(object sender, EventArgs e)
        {

            App.minhaLista.Add(umVisitante);
            Navigation.PopAsync();

        }
    }
}