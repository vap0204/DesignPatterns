namespace VoteMachineSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1. дава грешен резултат в многонишкова среда
            //обекти на класа Singleton
            /* 
              VoteMachine vm1 = VoteMachine.Instance;
              VoteMachine vm2 = VoteMachine.Instance;
              VoteMachine vm3 = VoteMachine.Instance;

              vm1.RegisterVote();
              vm2.RegisterVote();
              vm3.RegisterVote();

              Console.WriteLine(vm1.TotalVotes);
            */
            #endregion

            //Singleton класът VoteMachine ще работи перфектно в синхронните повиквания, където всеки потребител ще регистрира гласа си един по един.
            //Ако всеки потребител ще регистрира гласа си един по един, тогава защо се нуждаем от Singleton клас?
            //В сценарий от реалния живот може да има множество потребители регистриращи гласа си асинхронно, без да знаят.
            //Да видим как се държи класът VoteMachine при паралелно гласуване(многонишкова среда).

            #region 2. резултатът може да варира, но ще покаже правилния общ брой
            //тестване на Singleton обект с помощта на паралелен клас
            var numbers = Enumerable.Range(0, 10);

            Parallel.ForEach(numbers, i =>
            {
                var vm = VoteMachine.Instance;
                vm.RegisterVote();
            });

            Console.WriteLine(VoteMachine.Instance.TotalVotes);
            #endregion
        }
    }
}