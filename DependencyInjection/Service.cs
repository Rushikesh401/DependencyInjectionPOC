using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Service
    {
        private IRepository _repository;
        public Service(IRepository repository)
        {
            _repository = repository;
        }

        public void Execute()
        {
            _repository.GetData();
            Console.WriteLine("Service Executed");
        }

    }
}
