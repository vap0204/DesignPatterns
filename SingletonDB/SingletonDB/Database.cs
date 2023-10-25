using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDB
{
    // Singleton klas koito ima samo edna instanciq i predostawq globalen dostup do neq 
    // sealed-> predotvratqwa nasledqwane
    public sealed class Database
    {
        //statichna instanciq na Database Klasa 
        private static readonly Database instance = new Database();
        private Dictionary<string, string> storage = new Dictionary<string, string>();
        //zatvoren konstruktoe za da predotvrati drugi instancii
        private Database()
        {

        }
        //Svoistvo za dostup do edinstwenata instanciq  na klasa
        public static Database Instance => instance;
        //method za suhranenie
        public void Storage(string key,string value)
        {
            storage[key] = value;
        }
        //method za izvlichane na danni
        public string Retrive(string key)
        {
            return storage.ContainsKey(key) ? storage[key] : null;
        }
    }
}
