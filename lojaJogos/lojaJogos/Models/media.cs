using System.ComponentModel.DataAnnotations;

namespace lojaJogos.Models {
    public class Media {

        [Key]
        public int ID { get; set; }

        public string Fotografia { get; set; }

        public string Video { get; set; }

    }
}