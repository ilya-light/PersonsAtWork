using Persons.App.Persons;
using Persons.Domain.Models;
using System;
using System.Collections.Generic;

namespace Persons.Persistence.DbCommand
{
    public class PersonsReader : Repository, IPersonsReader
    {
        public List<Person> GetPeople()
        {
            var persons = new List<Person>();

            InitCommand("GetAllPersons");
            using (var reader = _command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var person = new Person
                    {
                        Name = $"{reader[0]} {reader[1].ToString()[0]}.{reader[2].ToString()[0]}.",
                        Status = reader[3].ToString(),
                        Department = reader[4].ToString(),
                        Post = reader[5].ToString(),
                        DateEmploy = reader[6] as DateTime?,
                        DateUnemploy = reader[7] as DateTime?
                    };

                    persons.Add(person);
                }
            }
            DisposeCommand();
            return persons;
        }
    }
}
