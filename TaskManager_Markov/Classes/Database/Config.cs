using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_Markov.Classes.Database
{
    public class Config
    {
        public static readonly string connection = "server=localhost;" +
            "uid=root;" + "pwd=;" + "database=TaskManager;";

        public static readonly MySqlServerVersion version = new MySqlServerVersion(new Version(8, 0, 11));
    }
}
