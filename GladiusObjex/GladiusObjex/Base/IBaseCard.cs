using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.Base
{
    public interface IBaseCard : IBase
    {
        bool IsPassive { get; set; }
        string CardCode { get; set; }
        string CardName { get; set; }
        string CardDesc { get; set; }
        string SpeCode1 { get; set; }
        string SpeCode2 { get; set; }
        string SpeCode3 { get; set; }
        string DbSource { get; set; }
        string DbSourceRef { get; set; }
        DateTime LastUpdate { get; set; }
    }
}
