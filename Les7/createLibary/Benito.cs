using System;
using System.Collections.Generic;
using System.Text;

namespace Nwuje
{
    class Benito
    {
        public static string SystemInfo()
        {
            string info;
            info = $"Machinenaam: {Environment.MachineName}\n" +
                $"Gebruikersnaam: {Environment.UserName}";
            return info;
        }

    }
}
