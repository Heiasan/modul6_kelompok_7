using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa1302204126 d = new DataMahasiswa1302204126();
            d.ReadJSON();
            Console.WriteLine();
            TeamMembers1302204126 s = new TeamMembers1302204126();
            s.ReadJSON();
        }
    }
}
