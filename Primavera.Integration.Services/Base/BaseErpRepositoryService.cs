using Primavera.Integration.Engine;
using System;
using System.Threading;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Primavera.Integration.Services.Base
{
    public class BaseErpRepositoryService<TRecord> : IRepositoryService<TRecord>
    {
        protected log4net.ILog Logger => log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected string User => Thread.CurrentPrincipal.Identity.Name;

        protected string DebugStr = "User={0} Company={1} {2} {3}";

        public BaseErpRepositoryService(string company, string user, string password)
        {
            PriEngine.CreatContext(company, user, password);
        }

        public TRecord Create(TRecord record)
        {
            throw new NotImplementedException();
        }

        public void Delete(object key)
        {
            throw new NotImplementedException();
        }

        public TRecord Get(object key)
        {
            throw new NotImplementedException();
        }

        public TRecord Update(TRecord record)
        {
            throw new NotImplementedException();
        }
    }
}
