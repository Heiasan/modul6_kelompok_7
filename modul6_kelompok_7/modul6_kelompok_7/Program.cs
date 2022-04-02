using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace modul6_kelompok_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa1302200020 d = new DataMahasiswa1302200020();
            d.ReadJSON();
            Console.WriteLine();
            TeamMembers1302200020 s = new TeamMembers1302200020();
            s.ReadJSON();
            Console.WriteLine();
            GlossaryItem1302200020 g = new GlossaryItem1302200020();
            g.ReadJSON();
        }
    }
}