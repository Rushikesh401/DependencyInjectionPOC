// See https://aka.ms/new-console-template for more information

using DependencyInjection;

class Program

{
    static void Main(String[] strings)
    { 
        IRepository repository = new Repository();
        Service service = new Service(repository);
        service.Execute();
    }

}

