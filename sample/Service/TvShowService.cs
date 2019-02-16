using System.Collections.Generic;
using System.Linq;
using sample.Models;
namespace sample.Service {
    public class TvShowService {
        private readonly List<TvShow> shows;

        public TvShowService () {

            this.shows = new List<TvShow> {
                new TvShow { id = 1, name = "Game of Thrones", cast = new List<Cast> { new Cast { id = 7, name = "Mike Vogel", birthday = "1979-07-17" }, new Cast { id = 9, name = "Dean Norris", birthday = "1963-04-08" } } },
                new TvShow { id = 4, name = "Big Bang Theory", cast = new List<Cast> { new Cast { id = 6, name = "Michael Emerson", birthday = "1950-01-01" } } },
            };

        }

        public List<TvShow> GetShows () {
           return this.shows;
        }
    }
}