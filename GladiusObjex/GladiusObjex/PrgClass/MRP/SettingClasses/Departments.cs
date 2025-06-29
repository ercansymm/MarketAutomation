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

namespace GladiusObjex.PrgClass.MRP.SettingClasses
{
    public class Departments:gsBase
    {
        private string _CardName;
        [Display(Name = "Departman Adı")]
        [DataType("nvarchar")]
        [StringLength(150)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        public Departments()
        {
            TableName = "Departments";

            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));

            this.Ref = Guid.NewGuid();
            this.CardName = "";
        }
    }
}
