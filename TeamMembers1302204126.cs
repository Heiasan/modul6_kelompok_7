using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
using System.IO;

namespace modul6_kelompok_7
{
    internal class TeamMembers1302204126
    {
        string jsonFilePath = @"C:\Users\kddk7\praktikum_kpl\modul6_kelompok_7\jurnal6_2_1302204026.json";
        public void ReadJSON()
        {
            string jsonFile = File.ReadAllText(jsonFilePath);
            dynamic data = JsonConvert.DeserializeObject(jsonFile);

            Console.WriteLine("Team member list :");
            foreach (var item in data.members)
            {

                Console.WriteLine(item.nim + " " + item.firstName + " " + item.lastName + " " + item.age + " " + item.gender);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
