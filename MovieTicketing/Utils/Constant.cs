using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketing
{

    public enum ErrorCode
    {
        Success = 0,
        Error = 1
    }

    public enum Role 
    {
        Staff,
        Admin
    }
    public enum Genre { 
        Comedy,
        Action,
        Animation,
        Horror,
        Suspense,
        Thriller,
        Sci_Fi,
        Romantic_Comedy
    }
    public enum cinema { 
        Cinema_1,
        Cinema_2,
        Cinema_3,
        Cinema_4,
        Cinema_5,
    }

    public class Constant { }

}
