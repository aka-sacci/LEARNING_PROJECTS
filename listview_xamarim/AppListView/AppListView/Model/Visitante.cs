using System;
using System.Collections.Generic;
using System.Text;

namespace AppListView.Model
{
    public class Visitante
    {
        private long id;
        private string nome;
        private string descricao;
        private string end_image;
        
       
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string End_image { get => end_image; set => end_image = value; }
        public long Id { get => id; set => id = value; }
    }

}
