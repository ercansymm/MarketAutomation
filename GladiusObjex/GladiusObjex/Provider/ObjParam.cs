using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiusObjex.Provider
{
    public class ObjParam
    {
        public string ParamName { get; set; }
        public SqlDbType ParamType { get; set; }
        public object ParamValue { get; set; }

        public ObjParam()
        {
            ParamName = "";
        }

        public ObjParam(string paramName, SqlDbType paramType, object paramValue)
        {
            ParamName = paramName;
            ParamType = paramType;
            ParamValue = paramValue;
        }
    }
}
