using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GestaoFrotaLucasSacci.Model;

namespace GestaoFrotaLucasSacci.views.notabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class attVeiculo : ContentPage
    {
        public Veiculo edtVeiculo;
        public attVeiculo()
        {
            InitializeComponent();
        }
        public attVeiculo(Veiculo veiculo)
        {
            InitializeComponent();

            edtVeiculo = new Veiculo() {

                Placa = veiculo.Placa,
                Fabricante = veiculo.Fabricante,
                Modelo = veiculo.Modelo,
                Cor = veiculo.Cor,
                Ano_Modelo = veiculo.Ano_Modelo,
                KM = veiculo.KM
            };

            BindingContext = edtVeiculo;

        }

        private void gravar_Clicked(object sender, EventArgs e)
        {
            foreach (Veiculo veic in App.listaVeiculos)
            {
                if (veic.Placa == edtVeiculo.Placa)
                {
                    App.listaVeiculos.Remove(veic);
                    App.listaVeiculos.Add(edtVeiculo);
                    break;
                }
            }
            Navigation.PopAsync();
        }
    }
}