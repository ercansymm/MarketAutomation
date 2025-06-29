using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.Base
{
    public interface IDocument : IBase
    {
        string Modul { get; set; }
        string DocType { get; set; }
        DateTime DocDate { get; set; }
        string DocSerial { get; set; }
        string DocSerialNo { get; set; }
        string DocFormalNo { get; set; }
        string DocDesc { get; set; }
    }
}
