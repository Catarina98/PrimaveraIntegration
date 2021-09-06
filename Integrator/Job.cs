using Integrator.Properties;
using System;
using Primavera.Integration.Services.DocumentoInterno;
using Primavera.Integration.Services.Models.DocumentoInterno;
using System.Collections.Generic;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Integrator
{
    public class Job
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly string PRIMAVERA_EMPRESA;
        private readonly string PRIMAVERA_UTILIZADOR;
        private readonly string PRIMAVERA_PASSWORD;
        public Job()
        {

            PRIMAVERA_EMPRESA = Settings.Default.PriEmpresa;
            PRIMAVERA_UTILIZADOR = Settings.Default.PriUtilizador;
            PRIMAVERA_PASSWORD = Settings.Default.PriPassword;
            
            log.Info("jobdone: PRIMAVERA_EMPRESA- "+ PRIMAVERA_EMPRESA + " | PRIMAVERA_UTILIZADOR- "+ PRIMAVERA_UTILIZADOR + " | PRIMAVERA_PASSWORD- " + PRIMAVERA_PASSWORD);
        }
        public void Start()
        {
            try
            {
                TestDocumentoInternoService();
            }
            catch(Exception e)
            {
                log.Error(e.Message, e);
            }
            
            
        }

        private void TestDocumentoInternoService()
        {
            var service = new DocumentoInternoService(PRIMAVERA_EMPRESA, PRIMAVERA_UTILIZADOR, PRIMAVERA_PASSWORD);

            var linhas = new List<LinhaDocumentoInterno> {
                new LinhaDocumentoInterno("P11", "A1", 1, 1),
                new LinhaDocumentoInterno("P6", "A1", 1, 1),
                new LinhaDocumentoInterno("P5", "A1", 1, 1)
            };
            //var linha = new LinhaDocumentoInterno("001", "A1", 1, 1);

            service.Create(new Primavera.Integration.Services.Models.DocumentoInterno.DocumentoInterno(1, DateTime.Now, DateTime.Now, "ORC2", "2020", "",1, "DEV.PRT.0000052/2020", "C1","OBS" ,"1d45ce9f-0d77-11eb-912a-00505601071b", linhas), linhas);
            
            
        }
    }
}
