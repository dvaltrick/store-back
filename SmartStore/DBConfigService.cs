using Newtonsoft.Json;
using SmartStore.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SmartStore
{
    public static class DBConfigService
    {
        public static DBConfig Carregar()
        {
            var data = File.ReadAllText("dbconfig.json");

            var config = JsonConvert.DeserializeObject<DBConfig>(data);

            return config;
        }
    }
}
