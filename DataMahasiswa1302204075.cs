﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
using System.IO;


namespace modul6_kelompok_7
{
    internal class DataMahasiswa1302204075
    {
        string jsonFilePath = @"C:\Users\Acer\source\repos\modul6_kelompok7\modul6_kelompok_7/jurnal6_1_1302204075.json";
        public void ReadJSON()
        {
            string jsonFile = File.ReadAllText(jsonFilePath);
            dynamic data = JsonConvert.DeserializeObject(jsonFile);

            Console.WriteLine("First Name : " + data.firstName);
            Console.WriteLine("Last Name : " + data.lastName);
            Console.WriteLine("Gender : " + data.gender);
            Console.WriteLine("Age : " + data.age);
            Console.WriteLine("Alamat : " + data.address.streetAddress + ", " + data.address.city + ", " + data.address.state);
            Console.WriteLine("Mata Kuliah : ");
            foreach (var item in data.courses)
            {

                Console.WriteLine("     Kode matkul : " + item.code);
                Console.WriteLine("     Nama matkul : " + item.name);
            }
            Console.WriteLine();
        }
    }
}
