using GestaoFrotaLucasSacci.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GestaoFrotaLucasSacci
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ListaVeiculos.ItemsSource = App.listaVeiculos;
        }

        private void menu_editar_Clicked(object sender, EventArgs e)
        {

        }

        private void menu_excluir_Clicked(object sender, EventArgs e)
        {

        }

        private void novoRegistro_Clicked(object sender, EventArgs e)
        {

        }

        private void ListaVeiculos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}
