// See https://aka.ms/new-console-template for more information

using DependencyInjection;

class Program

{
    static void Main(String[] strings)
    { 
        Service service = new Service();
        service.Execute();
    }

}

