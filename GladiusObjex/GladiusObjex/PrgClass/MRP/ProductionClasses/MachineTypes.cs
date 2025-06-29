using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GladiusObjex.PrgClass.MRP.ProductionClasses
{
    public class MachineTypes:gsBase
    {
        private string _CardName;
        [Display(Name = "Saha Adı")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        public MachineTypes()
        {

            TableName = "MachineTypes";

            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));

            Ref = Guid.NewGuid();
            this.CardName = "";

        }
    }
}
