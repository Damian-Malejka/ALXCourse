using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientShowcase.Models
{//odpowiedz postmana "https://official-joke-api.appspot.com/random_joke" odpowiedz w json wzielismy i tu wkleilismy

    public class JokeResponse//Edit>paste Special>Paste Json as classes//ale mozna by samemu to zrobic recznie
    {
        public string Type { get; set; }
        public string Setup { get; set; }
        public string Punchline { get; set; }
        public int Id { get; set; }
    }

}
