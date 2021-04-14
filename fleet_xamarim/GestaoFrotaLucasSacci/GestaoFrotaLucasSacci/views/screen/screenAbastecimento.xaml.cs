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
    public partial class screenAbastecimento : ContentPage
    {
        public screenAbastecimento()
        {
            InitializeComponent();
            //carrega a lista do xaml
            ListaAbastecimento.ItemsSource = App.listaAbastecimento;

        }

        private void menu_editar_Clicked(object sender, EventArgs e)
        {
            MenuItem menu = sender as MenuItem;
            var context = menu.BindingContext as Abastecimento;
            Navigation.PushAsync(new attAbastecimento(context));
        }

        private async void menu_excluir_Clicked(object sender, EventArgs e)
        {
            

            MenuItem menu = sender as MenuItem;
            var context = menu.BindingContext as Abastecimento;
            // DisplayAlert("Placa:", placa, "Continuar");
            bool answer = await DisplayAlert("Alerta?", "Tem certeza que você deseja excluir o registro de abastecimento com código = '" + context.SEQ.ToString() + "'? \n" +
                "Valor: " + context.ValorTotal.ToString("C") + "\n" +
                "Data: " + context.Data.ToString("dd/MM/yyyy"), "Sim", "Não");

            if (answer == true)
            {
                //deleta registro
                App.listaAbastecimento.Remove(context);
                //atualiza tela
                OnAppearing();
            }
        }

        private void novoRegistro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new addAbastecimento());
        }
        protected override void OnAppearing()
        {
            //atualiza tela
            base.OnAppearing();
            ListaAbastecimento.ItemsSource = null;
            ListaAbastecimento.ItemsSource = App.listaAbastecimento;
        }

        private void ListaAbastecimento_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //mostra as informações
            var abs = (Abastecimento)(((ListView)sender).SelectedItem);
            DisplayAlert("Detalhes do abastecimento", "Data: " + abs.Data.ToString("dd/MM/yyyy") + "\n" +
                "Total: R$ " + abs.ValorTotal + "\n" +
                "Litros: " + abs.Litros + "\n" +
                "Distância: " + abs.KM + " Km\n" +
                "Código: " + abs.SEQ, "Continuar");
        }
    }
}