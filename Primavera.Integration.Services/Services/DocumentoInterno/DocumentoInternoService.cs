using System;
using System.Collections.Generic;
using IntBE100;
using Primavera.Integration.Engine;
using Primavera.Integration.Services.Models.DocumentoInterno;

namespace Primavera.Integration.Services.DocumentoInterno
{
    public class DocumentoInternoService : Base.BaseErpRepositoryService<Models.DocumentoInterno.DocumentoInterno>
    {

        public DocumentoInternoService(string company, string user, string password) : base(company, user, password)
        {
           
        }

        /// <summary>
        /// cria novo documento interno
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public Models.DocumentoInterno.DocumentoInterno Create(Models.DocumentoInterno.DocumentoInterno record, IEnumerable<LinhaDocumentoInterno> linhas)
        {
            var strAvisos = string.Empty;
            var strErr = string.Empty;
            var obraid = record.IDObra;

            Logger.Debug(string.Format(DebugStr, User, PriEngine.Empresa, "DocumentoInterno", record.Conteudo));
            IntBEDocumentoInterno docInterno = record;

            PriEngine.Engine.Internos.Documentos.PreencheDadosRelacionados(docInterno);

            IntBELinhasDocumentoInterno lines = new IntBELinhasDocumentoInterno();

            Logger.Debug(string.Format(DebugStr, User, PriEngine.Empresa, "DocumentoInterno", docInterno.Conteudo));

            foreach (LinhaDocumentoInterno linha in linhas)
            {
                PriEngine.Engine.Internos.Documentos.AdicionaLinha(docInterno, linha.Artigo, Armazem: linha.Armazem, PrecoUnitario: linha.PrecoUnitario, Quantidade: linha.Quantidade);
                lines = docInterno.Linhas;
            }
            foreach(IntBELinhaDocumentoInterno line in lines)
            {
                line.ObraID = obraid;
            }

            PriEngine.Engine.Internos.Documentos.ValidaActualizacao(docInterno, ref strErr);
            if(!string.IsNullOrEmpty(strErr))
            {
                Logger.Error(strErr);
                throw new ApplicationException(strErr);
            }
            PriEngine.Engine.Internos.Documentos.Actualiza(record, ref strAvisos);
            Logger.Warn(strAvisos);

            return record;
        }
        

    }
}
