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
    public partial class editar_visitante : ContentPage
    {
        public Visitante umVisitante;
        public editar_visitante()
        {
            InitializeComponent();
        }

        public editar_visitante(Visitante visitante)
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
        }

        private void gravar_Clicked(object sender, EventArgs e)
        {
            foreach (Visitante vs in App.minhaLista)
            {
                if (vs.Id == umVisitante.Id)
                {
                    App.minhaLista.Remove(vs);
                    App.minhaLista.Add(umVisitante);
                    break;
                }
            }
            Navigation.PopAsync();
        }
    }
}