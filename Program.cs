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
            DataMahasiswa1302204094 mio = new DataMahasiswa1302204094();
            mio.ReadJSON();
            Console.WriteLine();
            TeamMembers11302204094 miomio = new TeamMembers1302204094();
            miomio.ReadJSON();
            Console.WriteLine();
            GlossaryItem11302204094 pop = new GlossaryItem11302204094();
            pop.ReadJSON();
        }
    }
}