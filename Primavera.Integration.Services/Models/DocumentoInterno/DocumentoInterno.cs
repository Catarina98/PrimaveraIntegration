using IntBE100;
using System;
using System.Collections.Generic;

namespace Primavera.Integration.Services.Models.DocumentoInterno
{
    public class DocumentoInterno : IntBEDocumentoInterno
    {
        

        public DocumentoInterno(int numDoc, DateTime docDate, DateTime expDate, string tipoDoc, string serie,string tipoentidade, double cambio, string referencia, string entidade, string obs,string idobra,IEnumerable<LinhaDocumentoInterno> linhas)
        {
            Linhas = new LinhasDocumentoInterno(linhas);
            NumDoc = numDoc;
            Data = docDate;
            DataVencimento = expDate;
            Tipodoc = tipoDoc;
            Serie = serie;
            TipoEntidade = tipoentidade;
            Moeda = "USD";
            Cambio = cambio;
            CambioMBase = cambio;
            CambioMAlt = cambio;
            Referencia = referencia;
            Entidade = entidade;
            IDObra = idobra;
            Observacoes = obs;

        }
        public DocumentoInterno(int numDoc, DateTime docDate, DateTime expDate, string tipoDoc, string serie, string tipoentidade,double cambio, string referencia, string entidade, IEnumerable<LinhaDocumentoInterno> linhas)
        {
            Linhas = new LinhasDocumentoInterno(linhas);
            NumDoc = numDoc;
            Data = docDate;
            DataVencimento = expDate;
            Tipodoc = tipoDoc;
            Serie = serie;
            TipoEntidade = tipoentidade;
            Moeda = "EUR";
            Cambio = cambio;
            CambioMBase = cambio;
            CambioMAlt = cambio;
            Referencia = referencia;
            Entidade = entidade;

        }
        public override string ToString()
        {
            return $"DocInterno=[NumDoc:{NumDoc} Data:{Data} DataVenc:{DataVencimento} TipoDoc:{Tipodoc} Serie:{Serie} Entidade: {Entidade} TipoEnt:{TipoEntidade} Moeda:{Moeda} Cambio:{Cambio} Referenc:{Referencia} IDObra:{IDObra} LinhasDocInterno:{Linhas} ]";
        }
    }
}
