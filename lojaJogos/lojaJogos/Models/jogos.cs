using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lojaJogos.Models {
    public class Jogos {

        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        [ForeignKey("categoria")]
        public int CategoriaFK { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}