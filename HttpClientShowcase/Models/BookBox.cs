﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientShowcase.Models
{
    public class BookBox
    {
        public int Id { get; set; }
        public Book? Book { get; set; }//ten znak zapytania mowimy ze zdajemy sobie sprawe ze ta wartosc moze byc nullem przez co nie podkresla na zielono, mowimy ze wiemy to ze tak chcemy
    }
}
