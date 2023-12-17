using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTicketing.AppData;

namespace Dbsys
{
    public class TicketLogged
    {
        //
        private static TicketLogged _instance;


        // *********** Member 
        public movieTicketing movieTickets{ get; set; }


        //************
        private TicketLogged()
        {

        }

        public static TicketLogged GetInstance()
        {
            if (_instance == null)
                _instance = new TicketLogged();
            return _instance;
        }
    }
}
