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
            {
                DataMahasiswa_1302204026 d = new DataMahasiswa_1302204026();
                d.ReadJSON();
                Console.WriteLine();
                TeamMembers_1302204026 s = new TeamMembers_1302204026();
                s.ReadJSON();
            }
        }
    }
}
