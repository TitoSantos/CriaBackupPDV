using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriaBackupPDV.Entities
{
    class Arquivo
    {
        public string Name { get; set; }
        public int Version { get; set; }
        public int NumberDraft { get; set; }

        public Arquivo()
        {
                
        }

        public Arquivo(string name, int version, int numberDraft)
        {
            Name = name;
            Version = version;
            NumberDraft = numberDraft;
        }
    }
}
