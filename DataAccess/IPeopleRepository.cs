using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess
{
    public interface IPeopleRepository
    {
        Task<List<Person>> GetPeople();
        Task InsertPerson(Person person);
        Task UpdatePerson(Person person);
        Task DeletePerson(Person person);
    }
}
