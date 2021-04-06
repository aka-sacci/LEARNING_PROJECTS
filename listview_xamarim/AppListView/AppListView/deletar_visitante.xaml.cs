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
    public partial class deletar_visitante : ContentPage
    {
        public Visitante umVisitante;
        public deletar_visitante()
        {
            InitializeComponent();
        }

        public deletar_visitante(Visitante visitante)
        {
            InitializeComponent();
            umVisitante = new Visitante()
            {
                Id = visitante.Id,
                Descricao = visitante.Descricao,
                End_image = visitante.End_image,
                Nome = visitante.Nome
                
            };
            BindingContext = umVisitante;
            umVisitante = visitante;
        }
        private void deletar_Clicked(object sender, EventArgs e)
        {
            
            App.minhaLista.Remove(umVisitante);
            Navigation.PopAsync();
        }
    }
}