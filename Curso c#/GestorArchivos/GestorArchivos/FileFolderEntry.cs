using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorArchivos
{
    public class FileFolderEntry
    {
        public bool IsFolder { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
    }
}
