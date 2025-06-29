using GladiusObjex.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GladiusObjex.Provider
{
    public interface ICustomObject : IBase
    {

        [NotMapped]
        List<ObjColumn> Columns { get; }

        [NotMapped]
        string TableName { get; }



        void ClearUpdateColumns();
    }
}
