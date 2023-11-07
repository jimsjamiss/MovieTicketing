using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketing.AppData
{
    public class movieInfo
    {
        public movieInfo()
        {
         
        
        }
        public int mvID { get; set; }
        public string mvTitle { get; set; }
        public string mvGenre { get; set; }
        public string mvDate { get; set; }
        public string mvHours { get; set; }
    }
}
