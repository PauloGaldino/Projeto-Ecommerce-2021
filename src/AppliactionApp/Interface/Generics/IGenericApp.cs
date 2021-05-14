using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppliactionApp.Interface.Generics
{
    /// <summary>
    /// Interface responsável pelos 
    /// métodos que iram aparecer no sistema
    /// </summary>

    public interface IGenericApp<T> where T : class
    {
        //Métodos CRUD
        Task Add(T Object);
        Task Update(T Object);
        Task Delete(T Object);

        Task<T> GetEntityById(int Id);
        Task<List<T>> List();

    }
}
