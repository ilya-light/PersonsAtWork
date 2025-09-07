using Persons.Domain.Models;
using System.Collections.Generic;

namespace Persons.App.Persons
{
    public interface IPersonsReader
    {
        List<Person> GetPeople(); 
    }
}
