using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Management_System
{
    class DB
    {


        public string dbconnect()
        {

            string con = "server = localhost;user id =root;password=;database=tms";
            return con;
        }

    }
}
