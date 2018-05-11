using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lojaJogos.Models {
    public class Jogos {

        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string Descricao { get; set; }

        public string Chave { get; set; }

        public virtual ICollection<Categoria> ListaDeCategorias { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteFK { get; set; }
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("Media")]
        public int MediaFK { get; set; }
        public virtual Media Media { get; set; }
    }
}