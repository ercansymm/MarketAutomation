using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.PrgClass.Netsis
{
    public class dmsApproval : gsBase
    {
        private int _departmentRef;
        public int departmentRef { get => _departmentRef; set { _departmentRef = value; SetUpdated("departmentRef", value); } }

        private int _categoriRef;
        public int categoriRef { get => _categoriRef; set { _categoriRef = value; SetUpdated("categoriRef", value); } }

        private int _userRef;
        public int userRef { get => _userRef; set { _userRef = value; SetUpdated("userRef", value); } }

        private string _erpCode;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string erpCode { get => _erpCode; set { _erpCode = value; SetUpdated("erpCode", value); } }

        private int _level_;
        public int level_ { get => _level_; set { _level_ = value; SetUpdated("level_", value); } }

        public dmsApproval()
        {
            TableName = "dmsApproval";

            Columns.Add(new ObjColumn("departmentRef", SqlDbType.Int, 0, false, false));
            Columns.Add(new ObjColumn("categoriRef", SqlDbType.Int, 0, false, false));
            Columns.Add(new ObjColumn("userRef", SqlDbType.Int, 0, false, false));
            Columns.Add(new ObjColumn("level_", SqlDbType.Int, 0, false, false));
            Columns.Add(new ObjColumn("erpCode", SqlDbType.NVarChar, "", false, false));
        }
    }
}
