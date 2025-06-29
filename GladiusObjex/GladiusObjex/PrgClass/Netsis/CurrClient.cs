using GladiusObjex.BaseClass;
using GladiusObjex.Provider;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace GladiusObjex.PrgClass.Netsis
{
    public class CurrClient : gsBase
    {
        private string _ClientCode;
        [Display(Name = "")]
        [DataType("nvarchar")]
        [StringLength(250)]
        public string ClientCode { get => _ClientCode; set { _ClientCode = value; SetUpdated("ClientCode", value); } }

        public CurrClient()
        {
            TableName = "CurrClient";

            Columns.Add(new ObjColumn("ClientCode", SqlDbType.NVarChar, "", false, false));

            this.ClientCode = "";
        }

    }
}
