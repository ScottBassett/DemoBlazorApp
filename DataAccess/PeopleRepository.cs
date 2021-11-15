using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess
{
    public class people_repository : IPeopleRepository
    {
        private readonly ISqlDataAccess _db;

        public people_repository(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<Person>> GetPeople()
        {
            var sql = "SELECT * FROM dbo.People";

            return _db.LoadData<Person, dynamic>(
                sql, new { });
        }

        public Task InsertPerson(Person person)
        {
            var sql = @"INSERT INTO dbo.People(FirstName, LastName, Email)
                            values (@FirstName, @LastName, @Email)";

            return _db.SaveData(sql, person);
        }

        public Task DeletePerson(Person person)
        {
            var sql = @$"DELETE FROM dbo.People WHERE Email='{person.Email}';";

            return _db.SaveData(sql, person);
        }
    }
}
