using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTicketing.AppData;

namespace Dbsys
{
    public class MovieLogged
    {
        //
        private static MovieLogged _instance;


        // *********** Member 
        public movieShows movieAccount{ get; set; }


        //************
        private MovieLogged()
        {

        }

        public static MovieLogged GetInstance()
        {
            if (_instance == null)
                _instance = new MovieLogged();
            return _instance;
        }
    }
}
