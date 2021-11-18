using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSingleton.Classes
{
    public sealed class Singleton
    {
        
        

       
        private static Singleton _instance;
        private List<string> _servers = new List<string>();
        private Random _random = new Random();

        protected Singleton()
        {
            // List of available servers

            _servers.Add("ServerI");
            _servers.Add("ServerII");
            _servers.Add("ServerIII");
            _servers.Add("ServerIV");
            _servers.Add("ServerV");
        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }

        public string Server
        {
            get

            {
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }

        
    }
}
