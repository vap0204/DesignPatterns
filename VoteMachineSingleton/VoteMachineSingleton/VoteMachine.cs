using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteMachineSingleton
{
    #region 1. клас Singleton
    //не е thread safe (безопасен за нишки). Може да даде грешен резултат при многонишково приложение.
    /*
    public class VoteMachine
    {
        private static VoteMachine _instance = null;
        private int _totalVotes = 0;

        private VoteMachine()
        {
        }

        public static VoteMachine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new VoteMachine();
                }
                return _instance;
            }
        }
            
        //методът RegisterVote() увеличава броя на гласовете с 1
        public void RegisterVote()
        {
            _totalVotes += 1;
            Console.WriteLine("Registered Vote #" + _totalVotes);
        }
           
        //свойството TotalVotes връща общия брой регистрирани гласове
        public int TotalVotes
        {
            get
            {
                return _totalVotes;
            }
        }
    }
    */
    #endregion

    #region 2. thread safe Singleton клас
    //Използвайте thread lock (заключване на нишки) преди да създадете обект от Singleton клас, за да го направите thread-safe (безопасен за нишки).

    /*
    public class VoteMachine
    {
        private static VoteMachine _instance = null;
        private int _totalVotes = 0;

        private static readonly object lockObj = new object();
        private VoteMachine()
        {
        }

        public static VoteMachine Instance
        {
            get
            {
                //За да повишим производителността, можем да проверим два пъти _instance == null преди и след заключването
                if (_instance == null)
                {
                    lock (lockObj)
                    {
                        if (_instance == null)
                        {
                            _instance = new VoteMachine();
                        }
                    }
                }
                return _instance;
            }
        }
            
        //методът RegisterVote() увеличава броя на гласовете с 1
        public void RegisterVote()
        {
            _totalVotes += 1;
            Console.WriteLine("Registered Vote #" + _totalVotes);
        }
        
        //свойството TotalVotes връща общия брой регистрирани гласове
        public int TotalVotes
        {
            get
            {
                return _totalVotes;
            }
        }
    }
    */
    #endregion

    #region 3. Singleton клас, използвайки статичен конструктор
    /*
    public class VoteMachine
    {
        private static VoteMachine _instance = null;
        private int _totalVotes = 0;

        private static readonly object lockObj = new object();

        //Можете да създадете Singleton клас, като използвате статичен конструктор.
        //Статичният конструктор се стартира веднъж на домейн на приложение, когато има достъп до статичен член на клас.
        static VoteMachine()
        {
        }
       
        private VoteMachine()
        {
        }

        public static VoteMachine Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (lockObj)
                    {
                        if (_instance == null)
                        {
                            _instance = new VoteMachine();
                        }
                    }
                }
                return _instance;
            }
        }

        //методът RegisterVote() увеличава броя на гласовете с 1
        public void RegisterVote()
        {
            _totalVotes += 1;
            Console.WriteLine("Registered Vote #" + _totalVotes);
        }

        //свойството TotalVotes връща общия брой регистрирани гласове
        public int TotalVotes
        {
            get
            {
                return _totalVotes;
            }
        }
    }
    */
    #endregion

    #region 4. Singleton клас с мързелива инстанция (lazy instantiation)
    //Ако използвате .NET 4 или по-нова версия, използвайте Lazy<T>, за да създадете инстанция, само когато е необходимо.
    public sealed class VoteMachine
    {
        private static readonly Lazy<VoteMachine> _instance = new Lazy<VoteMachine>(() => new VoteMachine());
        private int _totalVotes = 0;
       
        private VoteMachine()
        {
        }

        public static VoteMachine Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        //методът RegisterVote() увеличава броя на гласовете с 1
        public void RegisterVote()
        {
            _totalVotes += 1;
            Console.WriteLine("Registered Vote #" + _totalVotes);
        }

        //свойството TotalVotes връща общия брой регистрирани гласове
        public int TotalVotes
        {
            get
            {
                return _totalVotes;
            }
        }
    }
    #endregion
}


