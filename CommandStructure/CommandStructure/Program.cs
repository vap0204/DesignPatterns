namespace CommandStructure {
    class Program{
         static void Main(string[] args)
        {
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi"));
            Reciever receiver = new Reciever();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send Email", "Save report"));
            invoker.DoSomethingImportant();

        }
    }

}
