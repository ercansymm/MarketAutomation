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

namespace GladiusObjex.PrgClass.MRP.SalesClasses
{
    public class DueCard:gsBase
    {
        private string _CardName;
        [Display(Name = "Tanım")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        private int _Days;
        public int Days { get => _Days; set { _Days = value; SetUpdated("Days", value); } }


        public DueCard()
        {

            TableName = "DueCard";

            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Days", SqlDbType.Int, "", false, false));

            this.CardName = "";
            this.Days = 0;

        }
    }
}
