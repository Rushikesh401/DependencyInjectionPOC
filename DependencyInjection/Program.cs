﻿// See https://aka.ms/new-console-template for more information

using DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Autofac;
class Program

{
    static void Main(String[] strings)
    {


        // Setup Autofac containe
        var builder = new ContainerBuilder();
        builder.RegisterType<Repository>().As<IRepository>();   
        builder.RegisterType<Service>();
        var container = builder.Build();


        // Resolve Service from the container
        using (var scope = container.BeginLifetimeScope())
        {
            var service = scope.Resolve<Service>();
            service.Execute();
        }


        // Setup DI container
        //var serviceProvider = new ServiceCollection()
        //    .AddTransient<IRepository, Repository>()
        //    .AddTransient<Service>()
        //    .BuildServiceProvider();


        //// Resolve Service from the container
        //var service = serviceProvider.GetRequiredService<Service>();
        //service.Execute();


        /* Using DI container above we eliminated need of  creating and managing 
        the instace of Repostory, it all handled by DI container
         */

        //IRepository repository = new Repository();
        //Service service = new Service(repository);

    }

}

