using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primavera.Integration.Services.Base
{
    /// <summary>
    ///     Interface base a implementar com os metodos de CRUD
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepositoryService<T>
    {
        //PageResult<T> Query(QueryRequest request);
        T Get(object key);
        T Create(T record);
        T Update(T record);
        void Delete(object key);
        //List<MetadataDto> GetMetadata();
    }
}
