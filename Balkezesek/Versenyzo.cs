using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    class Versenyzo
    {
        public string nev { get; set; }
        public string elso { get; set; }
        public string utolso { get; set; }
        public int suly { get; set; }
        public int magassag { get; set; }

        public Versenyzo(string sor)
        {
            string[] s = sor.Split(';');
            this.nev = s[0];
            this.elso = s[1];
            this.utolso = s[2];
            this.suly = int.Parse(s[3]);
            this.magassag = int.Parse(s[4]);
        }
    }
}
