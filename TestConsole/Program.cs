using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SRR.Contracts.DAL.Repositories;
using SRR.DataAccessLayer;
using SRR.DataAccessLayer.Repositories;

namespace TestConsole
{
    class Program
    {
        private static string GetAllErrMessages(Exception ex)
        {
            StringBuilder sbExceptionMessages = new StringBuilder();
            //assign the current exception as first object and then loop through its
            //inner exceptions till they are null
            for (Exception eCurrent = ex; eCurrent != null; eCurrent = eCurrent.InnerException)
            {
                sbExceptionMessages.AppendLine(eCurrent.Message);
            }
            return sbExceptionMessages.ToString();
        }

        static void Main(string[] args)
        {

            Exception ex1 = new Exception("a", new Exception("b", new Exception("c")));
            Console.WriteLine(GetAllErrMessages(ex1));
            Console.ReadLine();

            var ctx = new Entities();

            IApplicationRepository appRepository = new SRRApplicationRepository(ctx);
            IUserRepository userRepository = new SRRUserRepository(ctx);
            IEntityTagRepository tagRepository = new SRREntityTagRepository(ctx);


            var app1 = appRepository.GetById(9);
            app1.Tags.Add(tagRepository.GetById(5));
            appRepository.Update(app1);
            appRepository.Save();

            Console.WriteLine("dfg");
        }
    }
}
