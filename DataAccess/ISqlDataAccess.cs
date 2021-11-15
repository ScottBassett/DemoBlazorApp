using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface ISqlDataAccess
    {
        Task<List<T>> LoadData<T, TU>(string sql, TU parameters);
        Task SaveData<T>(string sql, T parameters);
    }
}
