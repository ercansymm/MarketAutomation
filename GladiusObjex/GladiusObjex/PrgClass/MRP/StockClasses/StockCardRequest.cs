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

namespace GladiusObjex.PrgClass.MRP.StockClasses
{
    public class StockCardRequest:gsBase
    {
        private string _CardName;
        [Display(Name = "Grup Adı")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private int _State;
        public int State { get => _State; set { _State = value; SetUpdated("State", value); } }

        private DateTime _RequestDate;
        public DateTime RequestDate { get => _RequestDate; set { _RequestDate = value; SetUpdated("RequestDate", value); } }

        public StockCardRequest()
        {
            TableName = "StockCardRequest";

            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("State", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("RequestDate", SqlDbType.DateTime, "", false, false));

            this.CardName = "";
            this.State = 0;
            this.Ref = Guid.NewGuid();
            this.RequestDate = DateTime.Now;
        }
    }
}
