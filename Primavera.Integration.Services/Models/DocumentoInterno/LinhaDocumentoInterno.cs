using IntBE100;
using System;

namespace Primavera.Integration.Services.Models.DocumentoInterno
{
    public class LinhaDocumentoInterno : IntBELinhaDocumentoInterno
    {
        /*public LinhaDocumentoInterno(DateTime date, double qtd, string armazem, string artigo, string tipo)
        {

            DataDocStock = date;
            Quantidade = qtd;
            Armazem = armazem;
            Artigo = artigo;
            Localizacao = "RECEPCAO";
            TipoLinha = "10";
            Unidade = "UN";
            TaxaIva = 4;
            CodigoIva = "04";
            MovimentaStock = true;
            if (!string.IsNullOrEmpty(tipo))
            {
                INV_EstadoDestino = (tipo == "ES") ? "DISP" : string.Empty;
                INV_EstadoOrigem = (tipo != "ES") ? "DISP" : string.Empty;
            }

        }*/
        public LinhaDocumentoInterno(DateTime date,double preco, double qtd, string armazem, string artigo)
        {

            DataDocStock = date;
            Quantidade = qtd;
            Armazem = armazem;
            Artigo = artigo;
            PrecoUnitario = preco;
            
            //Localizacao = "RECEPCAO";
            TipoLinha = "10";
            Unidade = "UN";
            TaxaIva = 23;
            CodigoIva = "23";
            //MovimentaStock = true;
        }
        public LinhaDocumentoInterno(string artigo, string armazem, double qtd, double preco)
        {
            Artigo = artigo;
            Armazem = armazem;
            Quantidade = qtd;
            PrecoUnitario = preco;
        }

        public override string ToString()
        {
            return $"Linha=[Artigo:{Artigo} DataDocStock: {DataDocStock} PrecoUnitario: {PrecoUnitario} Qtd: {Quantidade} Armazem: {Armazem} Localizacao: {Localizacao} TipoLinha: {TipoLinha} Unidade: {Unidade} TaxaIva: {TaxaIva} MovimentaStock: {MovimentaStock} INV_EstadoOrigem: {INV_EstadoOrigem} INV_EstadoDestino: {INV_EstadoDestino}]";
        }
    }
}
