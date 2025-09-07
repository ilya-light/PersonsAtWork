using Persons.Domain.Models;
using System.Collections.Generic;
using System;

namespace Persons.App.Common
{
    public interface IDatesReader
    {
        List<Dates> ReadDatesCount(bool uneployed, DateTime from, DateTime to, string status);
    }
}
