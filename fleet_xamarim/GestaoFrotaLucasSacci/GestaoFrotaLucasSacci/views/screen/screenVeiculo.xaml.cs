using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GestaoFrotaLucasSacci.views.notabbed;
using GestaoFrotaLucasSacci.Model;

namespace GestaoFrotaLucasSacci.views.screen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class screenVeiculo : ContentPage
    {
        public screenVeiculo()
        {
            InitializeComponent();
            ListaVeiculos.ItemsSource = App.listaVeiculos;
        }

        private void menu_editar_Clicked(object sender, EventArgs e)
        {
            MenuItem menu = sender as MenuItem;
            var context = menu.BindingContext as Veiculo;
            Navigation.PushAsync(new attVeiculo(context));
        }

        private async void menu_excluir_Clicked(object sender, EventArgs e)
        {
            MenuItem menu = sender as MenuItem;
            var context = menu.BindingContext as Veiculo;
            String placa = context.Placa;
            // DisplayAlert("Placa:", placa, "Continuar");
            bool answer = await DisplayAlert("Alerta?", "Tem certeza que você deseja excluir o registro do veículo com placa '" + placa + "' ? ", "Sim", "Não");

            if (answer == true) {
                //deleta registro
                App.listaVeiculos.Remove(context);
                OnAppearing();
            }
            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListaVeiculos.ItemsSource = null;
            ListaVeiculos.ItemsSource = App.listaVeiculos;
        }
        private void ListaVeiculos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var meuVeiculo = (Veiculo)(((ListView)sender).SelectedItem);
            DisplayAlert("Detalhes do veículo", "Placa: " + meuVeiculo.Placa + "\n" +
                "Marca: " + meuVeiculo.Fabricante + "\n" + 
                "Modelo: " + meuVeiculo.Modelo + "\n" +
                "Cor: " + meuVeiculo.Cor + "\n" +
                "Ano: " + meuVeiculo.Ano_Modelo + "\n" +
                "Quilometragem: " + meuVeiculo.KM + " Km", "Continuar");

        }

        private void novoRegistro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new addVeiculo());
        }

        private void mudarTela_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new screenAbastecimento());
        }
    }
}