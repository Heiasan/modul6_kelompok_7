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
    internal class TeamMembers1302200020
    {
        string jsonFilePath = @"D:\00_File Kampus\S4\KPL\PRAKTIKUM\TP KPL\modul6_kelompok_7\modul6_kelompok_7\\jurnal6_2_1302200020.json";
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