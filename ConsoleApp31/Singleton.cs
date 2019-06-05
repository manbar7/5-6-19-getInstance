using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Singleton
    {
        private static Singleton _instance;

        string path = "C:\\Users\\HackerU\\Desktop\\check\\check.txt";
        string text;

        private static object key = new object();
        private Singleton()
        {

        }

        public void WriteLog(string log)
        {
            text = text + log;
            File.WriteAllText(path, text);
            
       
        }

        public static Singleton GetInstance()
        {  
            if (_instance == null)
            {
                lock (key)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }
    }
}
