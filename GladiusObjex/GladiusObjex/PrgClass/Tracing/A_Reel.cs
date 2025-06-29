using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace GladiusObjex.PrgClass.Tracing
{
    public class A_Reel : gsBase
    {
        private bool _IsPassive;
        public bool IsPassive { get => _IsPassive; set { _IsPassive = value; SetUpdated("IsPassive", value); } }

        private string _ReelName;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string ReelName { get => _ReelName; set { _ReelName = value; SetUpdated("ReelName", value); } }

        private string _Barcode;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(10)]
        public string Barcode { get => _Barcode; set { _Barcode = value; SetUpdated("Barcode", value); } }

        private Int16 _State;
        public Int16 State { get => _State; set { _State = value; SetUpdated("State", value); } }
        /*
          0. Boş
          1. Dolu
        */
        public A_Reel()
        {
            TableName = "A_Reel";

            Columns.Add(new ObjColumn("IsPassive", SqlDbType.Bit, "", false, false));
            Columns.Add(new ObjColumn("ReelName", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Barcode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("State", SqlDbType.TinyInt, 0, false, false));

            this.Ref = Guid.NewGuid();
            this.IsPassive = true;
            this.ReelName = "";
            this.Barcode = "";
            this.State = 0;
        }
    }
}
