using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFrotaLucasSacci.Model
{
    public class Abastecimento
    {

        private float km;
        private float litros;
        private float valorTotal;
        private DateTime data;
        private int seq;
  
        public float KM { get => km; set => km = value; }
        public float Litros { get => litros; set => litros = value; }
        public float ValorTotal { get => valorTotal; set => valorTotal = value; }
        public DateTime Data { get => data.Date; set => data = value; }
        public int SEQ { get => seq; set => seq = value; }
       





    }
}
