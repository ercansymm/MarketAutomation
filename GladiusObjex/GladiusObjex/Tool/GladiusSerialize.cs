using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace GladiusObjex.Tool
{
    public class GladiusSerialize : IDisposable
    {
        public static byte[] SerializeRead(object userAuth)
        {
            if (userAuth == null)
                return null;
            IFormatter formatter = new BinaryFormatter();
            Stream mstr = new MemoryStream();
            formatter.Serialize(mstr, userAuth);
            var bytes = new byte[mstr.Length];
            mstr.Position = 0;
            mstr.Read(bytes, 0, bytes.Length);
            return bytes;

        }

        public static object DeserializeWrite(byte[] bytes)
        {
            var docref = new object();
            try
            {
                if (bytes == null)
                    return null;
                if (bytes.Length == 0)
                    return null;
                IFormatter formatter = new BinaryFormatter();
                Stream mstr = new MemoryStream();
                mstr.Write(bytes, 0, bytes.Length);
                mstr.Position = 0;
                docref = formatter.Deserialize(mstr);

            }
            catch (Exception)
            {
                docref = null;
            }
            return (object)docref;

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
