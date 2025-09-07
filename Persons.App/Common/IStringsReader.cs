using System.Collections.Generic;

namespace Persons.App.Common
{
    public interface IStringsReader
    {
        List<string> GetStrings(string table);
    }
}
