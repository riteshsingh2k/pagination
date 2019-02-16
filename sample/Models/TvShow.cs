using System.Collections.Generic;
namespace sample.Models {
    public class TvShow {
        public int id { get; set; }
        public string name { get; set; }

        public List<Cast> cast { get; set; }
    }
}