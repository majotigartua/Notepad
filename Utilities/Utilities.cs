using System;
using System.Collections.Generic;
using System.Text;

namespace Notepad.Utilities
{
    public class Utilities
    {
        public string BuildQueryString(Dictionary<string, string> parameters)
        {
            var queryString = new StringBuilder("?");
            foreach (var parameter in parameters)
            {
                queryString.Append(Uri.EscapeDataString(parameter.Key));
                queryString.Append("=");
                queryString.Append(Uri.EscapeDataString(parameter.Value));
            }
            queryString.Length--;
            return queryString.ToString();
        }
    }
}