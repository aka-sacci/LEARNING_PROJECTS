using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFrotaLucasSacci.Model
{
    public class Veiculo
    {

        private int ano_modelo;
        private string placa;
        private string fabricante;
        private string modelo;
        private string cor;
        private float km;


        public string Placa { get => placa; set => placa = value; }
        public string  Fabricante { get => fabricante; set => fabricante = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Cor { get => cor; set => cor = value; }
        public int Ano_Modelo { get => ano_modelo; set => ano_modelo = value; }
        public float KM { get => km; set => km = value; }

    }
}
