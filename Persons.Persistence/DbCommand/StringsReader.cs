using System.Collections.Generic;
using Persons.App.Common;

namespace Persons.Persistence.DbCommand
{
    public class StringsReader : Repository, IStringsReader
    {
        public List<string> GetStrings(string table)
        {
            var strings = new List<string>();

            InitCommand($"Get{table}");
            using (var reader = _command.ExecuteReader())
            {
                while (reader.Read())
                {
                    strings.Add(reader[0].ToString());
                }
            }
            DisposeCommand();
            return strings;
        }
    }
}
