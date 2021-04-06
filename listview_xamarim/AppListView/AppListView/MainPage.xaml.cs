using AppListView.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppListView
{
    public partial class MainPage : ContentPage
    {
        //public static List<Visitante> minhaLista = new List<Visitante>();
        public MainPage()
        {
            InitializeComponent();
            //minhaLista.Add(new Visitante()
            //{
            //    Id = 1,
            //    Nome="Luciano",
            //    Descricao = "Visitante 1",
            //    End_image = "frame.jpeg"
            //}) ;
            //Visitante v = new Visitante();
            //v.Id = 2;
            //v.Nome = "Joaquim";
            //v.Descricao = "Visitante 2";
            //v.End_image = "frame.jpeg";
            //minhaLista.Add(v);

            //v = new Visitante();
            //v.Id = 3;
            //v.Nome = "Maria";S
            //v.Descricao = "Visitante 3";
            //v.End_image = "frame.jpeg";
            //minhaLista.Add(v);

            //minhaLista.Add(new Visitante()
            //{
            //    Id = 4,
            //    Nome = "Beltrano",
            //    Descricao = "Visitante 4",
            //    End_image = ""
            //});

            Lista.ItemsSource = App.minhaLista;


        }

        private void Lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var meuvisitante = (Visitante)(((ListView)sender).SelectedItem);
            DisplayAlert("Aviso", "Id: " + meuvisitante.Id+ "\nNome: " 
                         + meuvisitante.Nome, "Continuar");
        }

        private void NovaPagina_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new entrada_visitante());
           

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Lista.ItemsSource = null;
            Lista.ItemsSource = App.minhaLista;
        }
        private void menu_editar_Clicked(object sender, EventArgs e)
        {
            MenuItem menu = sender as MenuItem;
            var contexto = menu.BindingContext as Visitante;
            Navigation.PushAsync(new editar_visitante(contexto));
        }

        private void menu_excluir_Clicked(object sender, EventArgs e)
        {
            MenuItem menu = sender as MenuItem;
            var contexto = menu.BindingContext as Visitante;
            Navigation.PushAsync(new deletar_visitante(contexto));
        }
    }
}
