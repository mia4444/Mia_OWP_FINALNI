using Mia_OWP_FINALNI;
using Mia_OWP_FINALNI.Models;//moralo se dodati da bi Movies property funkcionisao
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mia_OWP_FINALNI.ViewModels
{
    public class RandomMovieViewModel
    {

        public Movie Movie { get; set; } //tip, pa naziv Movie
        public List<Customer> Customers { get; set; } //get nam služi da preperty-ju klase pristupimo i van klase, a set da možemo menjati vrednsot tog property-ja
    }
}