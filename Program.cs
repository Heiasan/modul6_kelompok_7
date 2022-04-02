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

            DataMahasiswa1302204075 d = new DataMahasiswa1302204075();
            d.ReadJSON();
            Console.WriteLine();
            TeamMembers1302204075 s = new TeamMembers1302204075();
            s.ReadJSON();
            Console.WriteLine();
            GlossaryItem1302204075 g = new GlossaryItem1302204075();
            g.ReadJSON();

            DataMahasiswa1302204126 d = new DataMahasiswa1302204126();
            d.ReadJSON();
            Console.WriteLine();
            TeamMembers1302204126 s = new TeamMembers1302204126();
            s.ReadJSON();
            Console.WriteLine();
            GlossaryItem1302204126 g = new GlossaryItem1302204126();
            g.ReadJSON();

            DataMahasiswa1302204094 mio = new DataMahasiswa1302204094();
            mio.ReadJSON();
            Console.WriteLine();
            TeamMembers11302204094 miomio = new TeamMembers1302204094();
            miomio.ReadJSON();
            Console.WriteLine();
            GlossaryItem11302204094 pop = new GlossaryItem11302204094();
            pop.ReadJSON();

                DataMahasiswa_1302204026 dd = new DataMahasiswa_1302204026();
                dd.ReadJSON();
                Console.WriteLine();
                TeamMembers_1302204026 ss = new TeamMembers_1302204026();
                ss.ReadJSON();
                Console.WriteLine();
                GlosarryItem gg = new GlosarryItem();
                gg.ReadJSON();
        }
    }
}