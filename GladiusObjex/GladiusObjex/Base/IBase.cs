using System;
using System.ComponentModel.DataAnnotations;


namespace GladiusObjex.Base
{
    public interface IBase : IDisposable
    {
        [Key]
        Guid Ref { get; set; }

    }
}
