using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Healthcare.dbcon
{
    public class MySQLDatabase
    {
        /*
        private int port;
        private String userid;
        private String password;
        private String server;
         */

        public static String getConnectionString()
        {
            String connString = "server=instance7904.db.xeround.com;port=5950;uid=sbose78_db1;pwd=qwerty;database=health1";
                
                //"server=8649385a-f53d-4037-b7c0-a0010132e5a6.mysql.sequelizer.com;database=db8649385af53d4037b7c0a0010132e5a6;uid=ndsrytgmhcyyeiwp;pwd=cP3Ee2tbvK5EJxCzp5qEuCKmQuxZXWScwzye2JWNWRswXR43KEQocwqGdPWRBBmG";
                
                //local mysql "server=localhost;uid=root;pwd=qwerty;database=test";                
                // Xeround:"server=instance7904.db.xeround.com;port=5950;uid=sbose78_db1;pwd=qwerty;database=health1";
            //Appharbor: "server=8649385a-f53d-4037-b7c0-a0010132e5a6.mysql.sequelizer.com;database=db8649385af53d4037b7c0a0010132e5a6;uid=ndsrytgmhcyyeiwp;pwd=cP3Ee2tbvK5EJxCzp5qEuCKmQuxZXWScwzye2JWNWRswXR43KEQocwqGdPWRBBmG"
            return connString;

        }
    }
}