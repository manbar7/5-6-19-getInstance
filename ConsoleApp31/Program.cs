using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton.GetInstance().WriteLog("hello");
            //Singleton.GetInstance().WriteLog("world");

            string k = "k";    
            
            Singleton.GetInstance().WriteLog(k);
        }


        
    }
}
