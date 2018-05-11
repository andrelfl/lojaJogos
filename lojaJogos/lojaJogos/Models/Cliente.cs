using System.ComponentModel.DataAnnotations;

namespace lojaJogos.Models {
    public class Cliente {

        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

    }
}