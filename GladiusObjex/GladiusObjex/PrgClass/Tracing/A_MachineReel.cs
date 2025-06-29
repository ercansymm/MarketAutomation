using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace GladiusObjex.PrgClass.Tracing
{
    public class A_MachineReel : gsBase
    {
        private Guid _MachineRef;
        public Guid MachineRef { get => _MachineRef; set { _MachineRef = value; SetUpdated("MachineRef", value); } }

        private int _Quequ; //Sıra
        public int Quequ { get => _Quequ; set { _Quequ = value; SetUpdated("Quequ", value); } }

        private string _Description;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(100)]
        public string Description { get => _Description; set { _Description = value; SetUpdated("Description", value); } }

        private string _Barcode;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(10)]
        public string Barcode { get => _Barcode; set { _Barcode = value; SetUpdated("Barcode", value); } }

        private decimal _Wastage;
        public decimal Wastage { get => _Wastage; set { _Wastage = value; SetUpdated("Wastage", value); } }

        private int _Inlet;//Giriş Yönü
        public int Inlet { get => _Inlet; set { _Inlet = value; SetUpdated("Inlet", value); } }
        /*
         * 0. Boy
         * 1. En
         */
       

        public A_MachineReel()
        {
            TableName = "A_MachineReel";

            Columns.Add(new ObjColumn("MachineRef", SqlDbType.UniqueIdentifier, "", false, false));
            Columns.Add(new ObjColumn("Quequ", SqlDbType.Int, "", false, false));
            Columns.Add(new ObjColumn("Description", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Barcode", SqlDbType.NVarChar, "", false, false));
            Columns.Add(new ObjColumn("Wastage", SqlDbType.Decimal, 0, false, false));
            Columns.Add(new ObjColumn("Inlet", SqlDbType.Int, 0, false, false));

            this.Ref = Guid.NewGuid();
            this.MachineRef = Guid.Empty;
            this.Quequ = 1;
            this.Description = "";
            this.Barcode = "";
            this.Wastage = 0;
            this.Inlet = 0;
        }


    }
}
