using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace lojaJogos.Models {
    public class Cliente {

        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public int Idade { get; set; }

        public virtual ICollection<Jogos> ListaDeJogos { get; set; }

    }
}