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

namespace GladiusObjex.PrgClass.MRP.ManagerClasses
{
    public class Notification:gsBase
    {
        private Guid _UserRef;
        public Guid UserRef { get => _UserRef; set { _UserRef = value; SetUpdated("UserRef", value); } }

        private bool _IsViewed;
        public bool IsViewed { get => _IsViewed; set { _IsViewed = value; SetUpdated("IsViewed", value); } }

        private string _Description;
        [Display(Name = "Açıklama")]
        [DataType("nvarchar")]
        [StringLength(2000)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        public Notification()
        {
            TableName = "Notification";

            Columns.Add(new ObjColumn("UserRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("IsViewed", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));

            this.Ref = Guid.NewGuid();
            this.Description = "";
            this.UserRef = Guid.Empty;
            this.IsViewed = false;
        }
    }
}
