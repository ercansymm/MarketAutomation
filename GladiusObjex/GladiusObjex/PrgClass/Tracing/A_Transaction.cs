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

namespace GladiusObjex.PrgClass.Tracing
{
    public class A_Transaction : gsBase
    {
        private Guid _OrderRef;
        public Guid OrderRef { get => _OrderRef; set { _OrderRef = value; SetUpdated("OrderRef", value); } }

        private Int16 _State_;
        public Int16 State_ { get => _State_; set { _State_ = value; SetUpdated("State_", value); } }

        private Int16 _ProductType;
        public Int16 ProductType { get => _ProductType; set { _ProductType = value; SetUpdated("ProductType", value); } }

        private DateTime _Date_;
        public DateTime Date_ { get => _Date_; set { _Date_ = value; SetUpdated("Date_", value); } }

        private string _Description_;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string Description_ { get => _Description_; set { _Description_ = value; SetUpdated("Description_", value); } }

        public A_Transaction()
        {
            this.TableName = "A_Transaction";

            Columns.Add(new ObjColumn("OrderRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("State_", SqlDbType.TinyInt, "", false, false));
            Columns.Add(new ObjColumn("ProductType", SqlDbType.TinyInt, "", false, false));
            Columns.Add(new ObjColumn("Date_", SqlDbType.DateTime, "", false, false));
            Columns.Add(new ObjColumn("Description_", SqlDbType.NVarChar, "", false, false));

            this.Ref = Guid.NewGuid();
            this.OrderRef = Guid.Empty;
            this.State_ = 0;
            this.ProductType = 1;
            this.Date_ = DateTime.Now;
            this.Description_ = "";
        }

    }
}
