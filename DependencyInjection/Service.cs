using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Service
    {
        private Repository _repository;
        public Service()
        {
            // tight coupling with the Respository class
            _repository = new Repository();
            
            //when tightly coupled, any changes made directly affect to dependent class. 
            //Here if any chnages made in Repository 
            //class will affect implementation of Service class


        }

        public void Execute()
        {
            _repository.GetData();
            Console.WriteLine("Service Executed");
        }

    }
}
