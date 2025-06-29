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
    public class FaultCauses:gsBase
    {
        private string _CardName;
        [Display(Name = "Neden")]
        [DataType("nvarchar")]
        [StringLength(500)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private string _FaultCode;
        [Display(Name = "Kod")]
        [DataType("nvarchar")]
        [StringLength(50)]
        public string FaultCode { get => _FaultCode; set { _FaultCode = value; SetUpdated("FaultCode", value); } }

        public FaultCauses()
        {
            TableName = "FaultCauses";

            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("FaultCode", SqlDbType.NVarChar, "", false, false));

            this.CardName = "";
            this.Ref = Guid.NewGuid();
            this.FaultCode = "";
        }
    }
}
