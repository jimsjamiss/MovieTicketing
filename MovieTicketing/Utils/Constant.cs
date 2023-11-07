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

    public enum Role { 
    
        Customer = 1,
        Staff =2,
        Admin = 3
    }
    public enum Genre { 
        Comedy,
        Action,
        Animation,
        Horror,
        Suspense,
        Thriller    
    }

    public class Constant { }

}
