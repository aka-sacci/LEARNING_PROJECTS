using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoFrotaLucasSacci.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestaoFrotaLucasSacci.views.notabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class addVeiculo : ContentPage
    {
        public Veiculo umVeiculo = new Veiculo();
        public addVeiculo()
        {
            InitializeComponent();
            BindingContext = umVeiculo;
        }

        private void gravar_Clicked(object sender, EventArgs e)
        {
            App.listaVeiculos.Add(umVeiculo);
            Navigation.PopAsync();
        }
    }
}