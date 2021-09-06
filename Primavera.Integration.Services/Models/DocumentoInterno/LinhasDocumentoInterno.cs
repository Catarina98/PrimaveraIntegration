using IntBE100;
using System.Collections.Generic;
using System.Collections;

namespace Primavera.Integration.Services.Models.DocumentoInterno
{
    public class LinhasDocumentoInterno : IntBELinhasDocumentoInterno,IEnumerable<LinhaDocumentoInterno>
    {
        
        public List<LinhaDocumentoInterno> items
        { private set; get; }

        public LinhasDocumentoInterno(IEnumerable<LinhaDocumentoInterno> _items)
        {
            items = new List<LinhaDocumentoInterno>(_items);
        }

        public LinhasDocumentoInterno()
        {
            items = new List<LinhaDocumentoInterno>();
        }

        public void Add(LinhaDocumentoInterno record)
        {
            items.Add(record);
        }


        public new IEnumerator<LinhaDocumentoInterno> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public override string ToString()
        {
            return $"LinhasDocumentoInterno=[{string.Join(",",items)}]";
        }
    }
}
