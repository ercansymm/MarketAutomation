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

namespace GladiusObjex.PrgClass.MRP.EmployeeClasses
{
    public class EmployeeTypes:gsBase
    {
        private string _CardName;
        [Display(Name = "Tip")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string CardName { get => _CardName; set { _CardName = value; SetUpdated("CardName", value); } }

        public EmployeeTypes getEmployeeType(Guid Ref)
        {
            ObjectManager mng = new ObjectManager(true, "erpconnStr");

            EmployeeTypes myType = new EmployeeTypes();

            myType = mng.GetObject<EmployeeTypes>(Ref);

            return myType;
        }

        public EmployeeTypes()
        {

            TableName = "EmployeeTypes";

            Columns.Add(new ObjColumn("CardName", SqlDbType.NVarChar, "", false, false));


            Ref = Guid.NewGuid();
            this.CardName = "";


        }
    }
}
